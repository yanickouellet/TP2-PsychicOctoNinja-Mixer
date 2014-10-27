using System;
using System.ComponentModel;

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

        [DisplayName("Titre")]
        public String Name { get; set; }
        [DisplayName("Durée")]
        public String Time { get; set; }
        [DisplayName("Artiste")]
        public String Artist { get; set; }
        [DisplayName("Album")]
        public String Album { get; set; }
        [DisplayName("Genre")]
        public String Genre { get; set; }
        [Browsable(false)]	
        public TagLib.File AudioFile { get; set; }
    }
}
