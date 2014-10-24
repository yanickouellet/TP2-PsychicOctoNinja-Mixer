using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;

namespace DJ.Core.Audio
{
    public class Playlist : BindingList<MusicItem>
    {
        private int _cursor;
        public bool Repeat { get; set; }

        public Playlist()
        {
            _cursor = 0;
        }

        public void AddItem(FileInfo file, int position)
        {
            var audioFile = TagLib.File.Create(file.FullName);
            var tag = audioFile.GetTag(TagLib.TagTypes.Id3v2, true) ?? audioFile.GetTag(TagLib.TagTypes.Apple, true);

            if (tag == null) return;
            var length = String.Concat(
                audioFile.Properties.Duration.Minutes, ":",
                audioFile.Properties.Duration.Seconds,
                audioFile.Properties.Duration.Seconds.ToString().Length == 1 ? "0" : ""
                );

            var musicItem = new MusicItem(tag.Title.Trim(), length, tag.FirstPerformer, tag.Album, tag.FirstGenre, audioFile);
            if (position == -1)
                Add(musicItem);
            else
                Insert(position, musicItem);
        }

        public MusicItem NextItem
        {
            get
            {
                if (Count == 0)
                    return null;
                if (_cursor >= Count)
                {
                    if (Repeat)
                        Reset();
                    else
                        return null;
                }
                return this[_cursor++];
            }
        }

        public void Reset()
        {
            _cursor = 0;
        }

        public bool Ended
        {
            get { return !Repeat && _cursor >= Count; }
        }
    }
}
