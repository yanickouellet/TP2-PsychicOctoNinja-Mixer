using System;

namespace DJ.Core.Events
{
    public class VolumeChangedEventArgs : EventArgs
    {
        private readonly int _level;

        public VolumeChangedEventArgs(int level)
        {
            _level = level;
        }

        public int Level
        {
            get { return _level; }
        }
    }
}