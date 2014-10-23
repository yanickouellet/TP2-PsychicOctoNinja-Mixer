using System;
using CSCore.Streams;

namespace DJ.Core.Events
{
    public class EqualizerChangedEventArgs : EventArgs
    {
        public EqualizerChangedEventArgs(int filterIndex, float value, Equalizer equalizer)
        {
            EqFilterEntry filter = equalizer.SampleFilters[filterIndex];
            filter.SetGain(value);
        }

    }
}
