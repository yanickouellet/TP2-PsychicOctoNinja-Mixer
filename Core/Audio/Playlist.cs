using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DJ.Core.Audio
{
    public class Playlist : List<MusicItem>
    {
        public MusicItem Pop()
        {
            if (Count == 0)
                return null;
            var item = this.Last();
            Remove(item);
            return item;
        }
    }
}
