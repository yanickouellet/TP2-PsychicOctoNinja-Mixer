using System;
using System.Diagnostics;
using System.Timers;
using DJ.Core.Audio;
using DJ.Core.Context;
using DJ.Core.Controllers.Interfaces;
using DJ.Core.Events;
using CSCore.Streams;
using Timer = System.Timers.Timer;

namespace DJ.Core.Controllers
{
    public abstract class TrackController : BaseController, ITrackController
    {
        public TrackController(AppContext context) : base(context) 
        {
            Context.AddEventOnTick(TimerOnElapsed);
        }

        public void LoadTrack(MusicItem item)
        {
            var currentVolume = 100;
            if (Track != null)
            {
                currentVolume = Track.Volume;
                Track.Dispose();
            }
            Track = new AudioMaterial(item);
            OnRaiseEvent(new TrackChangedEventArgs(item), RaiseTrackChangedEvent);
            Track.MasterVolume = Context.MasterVolume;
            SetVolume(currentVolume);
        }

        public void Play()
        {
            if (Track != null)
            {
                Track.Play();
            }
        }

        public void Cue()
        {
            Track.Pause();
        }

        public void Stop()
        {
            Track.Stop();
        }

        public void SetVolume(int volume)
        {
            Track.Volume = volume;
            OnRaiseEvent(new VolumeChangedEventArgs(volume), RaiseVolumeChangedEvent);
        }

        public void SetTime(int time)
        {
            throw new NotImplementedException();
        }

        public void SetFilter(int filterIndex, float value)
        {
            EqFilterEntry filter = Track.Equalizer.SampleFilters[filterIndex];
            filter.SetGain(value);
        }

        public bool Loop { set; private get; }

        public event EventHandler<TrackChangedEventArgs> RaiseTrackChangedEvent;
        public event EventHandler<VolumeChangedEventArgs> RaiseVolumeChangedEvent;

        protected abstract AudioMaterial Track { get; set; }

        protected virtual void TrackFinshed()
        {
            Debug.WriteLine("Track finished.");
        }

        private void CheckIfTrackFinshed()
        {
            if (Track.Finshed) TrackFinshed();
        }

        private void TimerOnElapsed(object sender, ElapsedEventArgs e)
        {
            if(Track != null) CheckIfTrackFinshed();
        }
    }
}
