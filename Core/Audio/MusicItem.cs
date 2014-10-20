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
            this.Name = name;
            this.Time = time;
            this.Artist = artist;
            this.Album = album;
            this.Genre = genre;
            this.AudioFile = audioFile;
        }

        public String Name { get; set; }
        public String Time { get; set; }
        public String Artist { get; set; }
        public String Album { get; set; }
        public String Genre { get; set; }
        public TagLib.File AudioFile { get; set; }
    }
}
