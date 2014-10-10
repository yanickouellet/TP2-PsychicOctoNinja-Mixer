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
            Context.MainTrack = new AudioMaterial(filename);
            OnRaiseEvent(new TrackChangedEventArgs(filename), RaiseTrackChangedEvent, x => Console.WriteLine(x.TrackName));
        }

        public void Play()
        {
            if (Context.MainTrack != null)
                Context.MainTrack.Play();
        }

        public void Cue()
        {
            Context.MainTrack.Pause();
        }

        public void Stop()
        {
            Context.MainTrack.Stop();
            Context.MainTrack.Dispose();
            Context.MainTrack = null;
        }

        public void SetVolume(uint volume)
        {
        }

        public void SetTime(uint time)
        {
            throw new NotImplementedException();
        }

        public bool Loop { set; private get; }

        public event EventHandler<TrackChangedEventArgs> RaiseTrackChangedEvent;

        protected abstract AudioMaterial Track { get; }
    }
}
