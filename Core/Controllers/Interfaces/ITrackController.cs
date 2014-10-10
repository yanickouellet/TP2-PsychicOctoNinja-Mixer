using System;
using DJ.Core.Events;

namespace DJ.Core.Controllers.Interfaces
{
    public interface ITrackController
    {
        void Play();
        void Cue();
        void Stop();
        void SetVolume(uint volume);
        void SetTime(uint time);
        bool Loop { set; }
        void LoadTrack(string filename);

        event EventHandler<TrackChangedEventArgs> RaiseTrackChangedEvent;
    }
}
