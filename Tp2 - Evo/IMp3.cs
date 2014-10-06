using System.Diagnostics;
using DJ.Winforms.Id3;

namespace DJ.Winforms
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
