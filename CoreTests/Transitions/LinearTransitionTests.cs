using System;
using System.IO;
using System.Threading;
using DJ.Core.Audio;
using DJ.Core.Helpers;
using DJ.Core.Transitions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DJ.CoreTests.Transitions
{
    [TestClass]
    public class LinearTransitionTests
    {
        [TestMethod]
        public void Constructor_ShouldCreateTransitionWithBothTracks()
        {
            var play = CreateAudioMaterial();
            var stop = CreateAudioMaterial("short");
            var transition = new LinearTransition(play, stop);

            Assert.AreSame(play, transition.TrackToPlay);
            Assert.AreEqual(stop, transition.TrackToStop);

            play.Dispose();
            stop.Dispose();
        }

        [TestMethod]
        public void Constructor_ShouldCreateTransitionWithOnlyTrackToStop()
        {
            var stop = CreateAudioMaterial("short");
            var transition = new LinearTransition(null, stop);

            Assert.IsNull(transition.TrackToPlay);
            Assert.AreEqual(stop, transition.TrackToStop);

            stop.Dispose();
        }

        [ExpectedException(typeof(ArgumentNullException))]
        [TestMethod]
        public void Constructor_ShouldThrowExceptionIfTrackToStopIsNull()
        {
            new LinearTransition(null, null);
        }

        [TestMethod]
        public void StartTransition_ShouldDoTransitionWithBothTracks()
        {
            var play = CreateAudioMaterial();
            var stop = CreateAudioMaterial("short");
            stop.Volume = 100;
            var transition = new LinearTransition(play, stop);

            transition.StartTransition(1);

            Assert.AreEqual(50, play.Volume);
            Assert.AreEqual(50, stop.Volume);

            transition.DoStep();

            Assert.IsTrue(transition.Finished);
            Assert.AreEqual(100, play.Volume);
            Assert.AreEqual(0, stop.Volume);

            play.Dispose();
        }

        [TestMethod]
        public void StartTransiton_ShouldDoTransitionWithOnlyTrackToStop()
        {
            var stop = CreateAudioMaterial("short");
            stop.Volume = 100;
            var transition = new LinearTransition(null, stop);

            transition.StartTransition(1);

            Assert.AreEqual(50, stop.Volume);

            transition.DoStep();

            Assert.IsTrue(transition.Finished);
            Assert.AreEqual(0, stop.Volume);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void StartTransition_ShouldThrowExceptionIfDurationGreatherThanTrackToPlayTime()
        {
            var play = CreateAudioMaterial();
            var stop = CreateAudioMaterial("short");
            stop.Volume = 100;
            var transition = new LinearTransition(play, stop);

            transition.StartTransition(95);
        }

        [ExpectedException(typeof(ObjectDisposedException))]
        [TestMethod]
        public void StartTransition_ShouldDisposeTrackToStopWhenFinished()
        {
            var play = CreateAudioMaterial();
            var stop = CreateAudioMaterial("short");
            stop.Volume = 100;
            var transition = new LinearTransition(play, stop);

            transition.StartTransition(1);
            transition.DoStep();

            play.Dispose();
            stop.Dispose();
        }

        [TestMethod]
        public void Pause_ShouldPauseTransitionAndStartAgainWithContinueToPlay()
        {
            var play = CreateAudioMaterial();
            var stop = CreateAudioMaterial("short");
            play.Stop();
            stop.Volume = 100;
            var transition = new LinearTransition(play, stop);

            transition.StartTransition(1);

            Assert.AreEqual(50, play.Volume);
            Assert.AreEqual(50, stop.Volume);

            Thread.Sleep(1000);
            transition.Pause();
            Assert.IsTrue(play.Position.TotalSeconds > 0.5 && play.Position.TotalSeconds < 1.5);

            Thread.Sleep(1000);
            Assert.IsTrue(play.Position.TotalSeconds > 0.5 && play.Position.TotalSeconds < 1.5);

            transition.ContinueToPlay();
            Thread.Sleep(1000);

            Assert.IsTrue(play.Position.TotalSeconds > 1.5 && play.Position.TotalSeconds < 2.5);

            transition.DoStep();

            Assert.IsTrue(transition.Finished);
            Assert.AreEqual(100, play.Volume);
            Assert.AreEqual(0, stop.Volume);

            play.Dispose();
        }

        [ExpectedException(typeof(ObjectDisposedException))]
        [TestMethod]
        public void Cancel_TransitionShouldDisposeTrackToPlay()
        {
            var play = CreateAudioMaterial();
            var stop = CreateAudioMaterial("short");
            stop.Volume = 100;
            var transition = new LinearTransition(play, stop);

            transition.CancelTransition();

            stop.Dispose();
            play.Dispose();
        }

        private AudioMaterial CreateAudioMaterial(string name = "dragonborn")
        {
            var path = string.Format("../../Resources/{0}.mp3", name);
            return new AudioMaterial(FileHelper.CreateMusicItem(new FileInfo(path)));
        }
    }
}
