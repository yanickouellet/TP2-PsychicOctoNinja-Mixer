using System;

namespace DJ.Core.Events
{
    public class TrackChangedEventArgs : EventArgs
    {
        private readonly string _trackName;

        public TrackChangedEventArgs(string trackName)
        {
            _trackName = trackName;
        }

        public string TrackName
        {
            get { return _trackName; }
        }
    }
}