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
		
		private int _masterVolume;

		public int MasterVolume 
		{ 
			get 
			{
				return _masterVolume;
			}

			set
			{
				_masterVolume = value;

				if (MainTrack != null)
					MainTrack.MasterVolume = _masterVolume;

				if (SecondaryTrack != null)
					SecondaryTrack.MasterVolume = _masterVolume;
			} 
		}

        public AppContext()
        {
            Playlist = new Playlist();
        }
    }
}
