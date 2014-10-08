using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSCore;
using CSCore.Codecs;
using CSCore.SoundOut;

namespace DJ.Core.Audio
{
    public class AudioMaterial : IDisposable
    {
        private IWaveSource _source;
        private ISoundOut _sound;

        public AudioMaterial(string filename)
        {
            _source = CodecFactory.Instance.GetCodec(filename);
            _sound = GetSoundSource();
            _sound.Initialize(_source);
        }

        public void Play()
        {
            _sound.Play();
        }

        public void Stop()
        {
            _sound.Stop();
        }

        private ISoundOut GetSoundSource()
        {
            if (WasapiOut.IsSupportedOnCurrentPlatform)
                return new WasapiOut();
            return new DirectSoundOut();
        }

        public void Dispose()
        {
            _sound.Dispose();
            _source.Dispose();
        }
    }
}
