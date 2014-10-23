using System;
using DJ.Core.Audio;

namespace DJ.Core.Events
{
    public class TrackChangedEventArgs : EventArgs
    {
        private readonly MusicItem _track;

        public TrackChangedEventArgs(MusicItem track)
        {
            _track = track;
        }

        public MusicItem Track
        {
            get { return _track; }
        }
    }
}