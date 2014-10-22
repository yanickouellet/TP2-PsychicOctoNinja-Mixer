using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DJ.Core.Audio
{
    public class Playlist : List<MusicItem>
    {
        private int _cursor;

        public Playlist()
        {
            _cursor = 0;
        }

        public MusicItem NextItem
        {
            get
            {
                if (Count == 0)
                    return null;
                if (_cursor >= Count)
                    _cursor = 0;
                return this[_cursor++];
            }
        }

    }
}
