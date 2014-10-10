using System;
using DJ.Core.Audio;
using DJ.Core.Context;
using DJ.Core.Controllers.Interfaces;
using DJ.Core.Events;

namespace DJ.Core.Controllers
{
    public abstract class TrackController : BaseController, ITrackController
    {
        public TrackController(AppContext context) : base(context) 
        {
        }

        public void LoadTrack(string filename)
        {
            Track = new AudioMaterial(filename);
            OnRaiseEvent(new TrackChangedEventArgs(filename), RaiseTrackChangedEvent);
            OnRaiseEvent(new VolumeChangedEventArgs(Track.Volume), RaiseVolumeChangedEvent);
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

        public bool Loop { set; private get; }

        public event EventHandler<TrackChangedEventArgs> RaiseTrackChangedEvent;
        public event EventHandler<VolumeChangedEventArgs> RaiseVolumeChangedEvent; 

        protected abstract AudioMaterial Track { get; set; }
    }
}
