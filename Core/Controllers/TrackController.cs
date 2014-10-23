using System;
using System.Diagnostics;
using System.Timers;
using DJ.Core.Audio;
using DJ.Core.Context;
using DJ.Core.Controllers.Interfaces;
using DJ.Core.Events;
using CSCore.Streams;

namespace DJ.Core.Controllers
{
    public abstract class TrackController : BaseController, ITrackController
    {
        private bool _finished;
        protected abstract AudioMaterial Track { get; set; }
        public bool Loop { set; private get; }

        public TrackController(AppContext context) : base(context)
        {
            _finished = true;
            Context.AddEventOnTick(TimerOnElapsed);
        }

        public void LoadTrack(MusicItem item)
        {
            var currentVolume = 50;
            if (Track != null)
            {
                currentVolume = Track.Volume;
                Track.Dispose();
            }
            Track = new AudioMaterial(item);
            OnRaiseEvent(new TrackChangedEventArgs(item), RaiseTrackChangedEvent);
            Track.MasterVolume = Context.MasterVolume;
            SetVolume(currentVolume);
            _finished = false;
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
            if (Track != null)
            {
                Track.Volume = volume;
                OnRaiseEvent(new VolumeChangedEventArgs(volume), RaiseVolumeChangedEvent);  
            }
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

        public event EventHandler<TrackChangedEventArgs> RaiseTrackChangedEvent;
        public event EventHandler<VolumeChangedEventArgs> RaiseVolumeChangedEvent;

        protected virtual void TrackFinshed()
        {
            Debug.WriteLine("Track finished.");
        }

        private void CheckIfTrackFinshed()
        {
            if (!_finished && Track != null && Track.Finshed)
            {
                _finished = true;
                TrackFinshed();
            }
        }

        private void TimerOnElapsed(object sender, ElapsedEventArgs e)
        {
            CheckIfTrackFinshed();
        }
    }
}
