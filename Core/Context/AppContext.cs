using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
﻿using DJ.Core.Audio;

namespace DJ.Core.Context
{
    public class AppContext : IContext
    {
        public AudioMaterial MainTrack { get; set; }
        public AudioMaterial SecondaryTrack { get; set; }
        public Playlist Playlist { get; set; }

        public AppContext()
        {
            Playlist = new Playlist();
        }
    }
}
