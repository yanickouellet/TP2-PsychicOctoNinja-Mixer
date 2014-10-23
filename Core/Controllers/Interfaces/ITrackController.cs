﻿using System;
using DJ.Core.Audio;
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
        void SetFilter(int filterIndex, float value);
        bool Loop { set; }
        void LoadTrack(MusicItem filename);

        event EventHandler<TrackChangedEventArgs> RaiseTrackChangedEvent;
        event EventHandler<VolumeChangedEventArgs> RaiseVolumeChangedEvent;
    }
}
