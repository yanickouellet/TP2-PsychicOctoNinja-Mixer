using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using DJ.Id3;

namespace DJ
{
    public interface IMp3
    {
        int Duration { get; }

        Stopwatch Position { get; }

        Id3Tag Tag { get; }

        void Open();
        void Play();
        void Stop();
        void Pause();
        void Close();
        void SetAudio(int volume);
    }
}
