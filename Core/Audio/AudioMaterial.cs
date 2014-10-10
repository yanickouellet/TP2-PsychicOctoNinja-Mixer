using System;
using CSCore;
using CSCore.Codecs;
using CSCore.SoundOut;

namespace DJ.Core.Audio
{
    public class AudioMaterial : IDisposable
    {
        private IWaveSource _source;
        private ISoundOut _sound;
        private string _filename;

        public AudioMaterial(string filename)
        {
            _filename = filename;
            _source = CodecFactory.Instance.GetCodec(filename);
            _sound = GetSoundSource();
            _sound.Initialize(_source);
        }

        public void Play()
        {
            _sound.Play();
        }

        public void Pause()
        {
            _sound.Pause();
        }

        public void Stop()
        {
            _sound.Stop();
            _sound.WaveSource.Position = 0;
        }

        public int Volume
        {
            set { _sound.Volume = (float)value/100; }
            get { return (int)_sound.Volume*100; }
        }

        private ISoundOut GetSoundSource()
        {
            if (WasapiOut.IsSupportedOnCurrentPlatform)
                return new WasapiOut();
            return new DirectSoundOut();
        }

        public void Dispose()
        {
            _sound.Stop();
            _sound.Dispose();
            _source.Dispose();
        }
    }
}
