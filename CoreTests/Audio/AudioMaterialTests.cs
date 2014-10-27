using System;
using System.IO;
using System.Threading;
using DJ.Core.Audio;
using DJ.Core.Helpers;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DJ.CoreTests.Audio
{
    [TestClass]
    public class AudioMaterialTests
    {
        [TestMethod]
        public void Constructor_ShouldInitializeANewSoundSource()
        {
            var material = CreateAudioMaterial();
            Assert.AreEqual(false, material.Finshed);
            Assert.AreEqual(0, material.Position.TotalSeconds);
            Assert.IsNotNull(material.Equalizer);
            material.Dispose();
        }

        [ExpectedException(typeof(ObjectDisposedException))]
        [TestMethod]
        public void Dispose_ShouldCorrectlyDisposeAllComponents()
        {
            var material = CreateAudioMaterial();
            material.Dispose();
            // It should throw an ObjectDisposedException, because the source has been
            // disposed
            material.Play();
        }

        [TestMethod]
        public void Play_ShouldCorrectlyPlay()
        {
            var material = CreateAudioMaterial();
            material.Play();
            Thread.Sleep(1000);
            material.Pause();
            Assert.IsTrue(material.Position.TotalSeconds > 0.5 && material.Position.TotalSeconds < 1.5);

            material.Dispose();
        }

        [TestMethod]
        public void Pause_ShouldCorrectlyPause()
        {
            var material = CreateAudioMaterial();

            material.Play();
            Thread.Sleep(1000);
            material.Pause();
            material.Play();
            Thread.Sleep(1000);
            material.Pause();

            Assert.IsTrue(material.Position.TotalSeconds > 1.5 && material.Position.TotalSeconds < 2.5);

            material.Dispose();
        }

        [TestMethod]
        public void Stop_ShouldStopTrackAndPutItToBeginning()
        {
            var material = CreateAudioMaterial();

            material.Play();
            Thread.Sleep(1000);
            material.Pause();
            Assert.IsTrue(material.Position.TotalSeconds > 0.5 && material.Position.TotalSeconds < 1.5);

            material.Stop();
            Assert.AreEqual(0, material.Position.TotalSeconds);

            material.Dispose();
        }

        [TestMethod]
        public void Play_ShouldRestartTrackAfterStop()
        {
            var material = CreateAudioMaterial();

            material.Play();
            Thread.Sleep(1000);
            material.Stop();

            material.Play();
            Thread.Sleep(1000);
            Assert.IsTrue(material.Position.TotalSeconds > 0.5 && material.Position.TotalSeconds < 1.5);

            material.Dispose();
        }

        [TestMethod]
        public void Length_SholdReturnTrackLength()
        {
            var material = CreateAudioMaterial();
            Assert.AreEqual(94, Math.Floor(material.Lenght.TotalSeconds));

            material.Dispose();
        }

        [TestMethod]
        public void PositionPercentage_ShouldSetPositionToCorrectValue()
        {
            var material = CreateAudioMaterial();

            material.PositionPercentage = 500;
            Assert.AreEqual(47, Math.Floor(material.Position.TotalSeconds));

            material.Dispose();
        }

        [TestMethod]
        public void Finished_ShouldIndicateCorrectValues()
        {
            var material = CreateAudioMaterial();
            Assert.IsFalse(material.Finshed);

            material.PositionPercentage = 500;
            Assert.IsFalse(material.Finshed);

            material.PositionPercentage = 1000;
            // The SetPosition on CSCore is not precise to the millisecond, so
            // we may need to wait few milliseconds before the track really end
            material.Play();
            Thread.Sleep(500);
            Assert.IsTrue(material.Finshed);

            material.Dispose();
        }

        private AudioMaterial CreateAudioMaterial(string name = "dragonborn")
        {
            var path = string.Format("../../Resources/{0}.mp3", name);
            return new AudioMaterial(FileHelper.CreateMusicItem(new FileInfo(path)));
        }
    }
}
