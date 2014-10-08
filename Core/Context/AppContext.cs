using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using CSCore;
using CSCore.Codecs;
using CSCore.SoundOut;
using DJ.Core.Audio;

namespace DJ.Core.Context
{
    public class AppContext : IContext
    {
        public AudioMaterial MainTrack { get; set; }
    }
}
