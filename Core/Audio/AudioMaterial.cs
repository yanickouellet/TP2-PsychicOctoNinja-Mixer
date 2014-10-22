using System;
using CSCore;
using CSCore.Codecs;
using CSCore.SoundOut;
using System.Diagnostics;
using CSCore.Streams;

namespace DJ.Core.Audio
{
    public class AudioMaterial : IDisposable
    {
        private IWaveSource _source;
        private ISoundOut _sound;
        private MusicItem _item;
		private int _masterVolume;
		private int _volume;
        public Equalizer Equalizer { get; set; }

		public int MasterVolume
		{
			get {return _masterVolume;}

			set
			{
				_masterVolume = value;
				ComputeVolume();
			}
		}

        public AudioMaterial(MusicItem item)
        {
            Equalizer equalizer;
            _item = item;
            _source = CodecFactory.Instance.GetCodec(_item.AudioFile.Name)
                   .AppendSource(Equalizer.Create10BandEqualizer, out equalizer)
                   .ToWaveSource(32);
            Equalizer = equalizer;
            
            _sound = GetSoundSource();
            _sound.Initialize(_source);
			ComputeVolume();
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
			set 
			{ 
				_volume = value;
				ComputeVolume();
			}

			get { return _volume; }
		}

        public TimeSpan Position
        {
            get { return _sound.WaveSource.GetPosition(); }
        }

        public TimeSpan Lenght
        {
            get { return _sound.WaveSource.GetLength(); }
        }

        public bool Finshed
        {
            get { return Position == Lenght; }
        }

		private void ComputeVolume()
		{
			float resultat = ((float)_volume / 100) * ((float)_masterVolume / 100);
			Debug.WriteLine("Volume: " + resultat.ToString());
			_sound.Volume = resultat;
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
