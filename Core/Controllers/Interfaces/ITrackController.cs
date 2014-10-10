using System;
using DJ.Core.Events;

namespace DJ.Core.Controllers.Interfaces
{
    public interface ITrackController
    {
        void Play();
        void Cue();
        void Stop();
        void SetVolume(int volume);
        void SetTime(int time);
        bool Loop { set; }
        void LoadTrack(string filename);

        event EventHandler<TrackChangedEventArgs> RaiseTrackChangedEvent;
        event EventHandler<VolumeChangedEventArgs> RaiseVolumeChangedEvent; 
    }
}
