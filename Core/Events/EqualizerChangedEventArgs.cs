using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DJ.Core.Audio;
using DJ.Core.Context;
using DJ.Core.Controllers.Interfaces;
using DJ.Core.Events;
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
