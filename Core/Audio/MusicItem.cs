using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DJ.Core.Audio
{
    public class MusicItem
    {
        public MusicItem(String name, String time, String artist, String album, String genre, TagLib.File audioFile)
        {
            Name = name;
            Time = time;
            Artist = artist;
            Album = album;
            Genre = genre;
            AudioFile = audioFile;
        }

        public String Name { get; set; }
        public String Time { get; set; }
        public String Artist { get; set; }
        public String Album { get; set; }
        public String Genre { get; set; }
        public TagLib.File AudioFile { get; set; }
    }
}
