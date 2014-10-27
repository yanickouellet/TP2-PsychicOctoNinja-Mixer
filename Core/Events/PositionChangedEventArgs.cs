using System;
using DJ.Core.Audio;

namespace DJ.Core.Events
{
    public class PositionChangedEventArgs : EventArgs
    {
        private readonly TimeSpan _time;
        private readonly int _percentage;

        public PositionChangedEventArgs(TimeSpan time, int percentage)
        {
            _time = time;
            _percentage = percentage;
        }

        public TimeSpan Time
        {
            get { return _time; }
        }

        public int Percentage
        {
            get { return _percentage; }
        }
    }
}