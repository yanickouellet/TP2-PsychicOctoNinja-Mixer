using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;

namespace DJ.Core.Audio
{
    public class Playlist : BindingList<MusicItem>
    {
        private int _cursor;
        private Random _randomGenerator;
        private List<MusicItem> _randomList;
        private bool _random;
        public bool Repeat { get; set; }

        public Playlist()
        {
            _cursor = 0;
            _randomGenerator = new Random();
            _randomList = new List<MusicItem>();
            AddingNew += OnAddingNew;
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
            get{ return Random ? NextRandom() : Next();}
        }

        public void Reset()
        {
            _cursor = 0;
            _randomList.Clear();
            _randomList.AddRange(this);
        }

        public bool Ended
        {
            get { return !Repeat && ((!Random && _cursor >= Count) || (Random && _randomList.Count == 0)); }
        }

        public bool Random
        {
            get { return _random; }
            set
            {
                _random = value;
                if (_random)
                {
                    _randomList.Clear();
                    _randomList.AddRange(this);
                }
            }
        }

        private MusicItem Next()
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

        private MusicItem NextRandom()
        {
            if (_randomList.Count == 0)
            {
                if 
                    (Repeat) Reset();
                else 
                    return null;
            }

            var position = _randomGenerator.Next(0, _randomList.Count);
            var item = _randomList[position];
            _randomList.RemoveAt(position);
            return item;
        }

        private void OnAddingNew(object sender, AddingNewEventArgs e)
        {
            _randomList.Add(e.NewObject as MusicItem);
        }

        protected override void RemoveItem(int index)
        {
            _randomList.Remove(this[index]);
            base.RemoveItem(index);
        }
    }
}
