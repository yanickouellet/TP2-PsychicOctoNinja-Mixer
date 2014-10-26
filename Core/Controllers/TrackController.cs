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
        private TimeSpan _lastPosition;
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

            OnRaiseEvent(new TrackChangedEventArgs(item), TrackChangedEvent);
            GeneratePositionChange();

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
            GeneratePositionChange();
        }

        public void SetVolume(int volume)
        {
            if (Track != null)
            {
                Track.Volume = volume;
                OnRaiseEvent(new VolumeChangedEventArgs(volume), VolumeChangedEvent);  
            }
        }

        public void SetTime(int time)
        {
            Track.PositionPercentage = time;
        }

        public void SetFilter(int filterIndex, float value)
        {
            EqFilterEntry filter = Track.Equalizer.SampleFilters[filterIndex];
            filter.SetGain(value);
        }

        public TimeSpan Length
        {
            get
            {
                if (Track == null)
                    return TimeSpan.Zero;
                return Track.Lenght;
            }
        }

        public event EventHandler<PositionChangedEventArgs> PositionChangedEvent;
        public event EventHandler<TrackChangedEventArgs> TrackChangedEvent;
        public event EventHandler<VolumeChangedEventArgs> VolumeChangedEvent;

        protected virtual void TrackFinshed()
        {
            Debug.WriteLine("Track finished.");
        }

        protected void RaiseTrackChangedEvent(TrackChangedEventArgs e)
        {
            OnRaiseEvent(e, TrackChangedEvent);
        }

        private void CheckIfTrackFinshed()
        {
            if (!_finished && Track != null && Track.Finshed)
            {
                _finished = true;
                TrackFinshed();
            }
        }

        private void CheckIfTimeUpdateNeeded()
        {
            if (Track != null && Track.Position != _lastPosition)
            {
                GeneratePositionChange();
            }
        }

        private void TimerOnElapsed(object sender, ElapsedEventArgs e)
        {
            CheckIfTrackFinshed();
            CheckIfTimeUpdateNeeded();
        }

        private void GeneratePositionChange()
        {
            OnRaiseEvent(new PositionChangedEventArgs(Track.Position, Track.PositionPercentage), PositionChangedEvent);
            _lastPosition = Track.Position;
        }

    }
}
