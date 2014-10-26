using System;
using CSCore;
using CSCore.Codecs;
using CSCore.SoundOut;
using System.Diagnostics;
using CSCore.Streams;
using TagLib.Matroska;

namespace DJ.Core.Audio
{
    public class AudioMaterial : IDisposable
    {
        private const int PercentageConst = 1000;
        private IWaveSource _source;
        private ISoundOut _sound;
		private int _masterVolume;
		private int _volume;

        public MusicItem Item { get; set; }
        public Equalizer Equalizer { get; set; }

        public AudioMaterial(MusicItem item)
        {
            Equalizer equalizer;
            Item = item;
            _source = CodecFactory.Instance.GetCodec(Item.AudioFile.Name)
                   .AppendSource(Equalizer.Create10BandEqualizer, out equalizer)
                   .ToWaveSource(32);
            Equalizer = equalizer;
            
            _sound = GetSoundSource();
            _sound.Initialize(_source);
			ComputeVolume();
        }

        public int MasterVolume
        {
            get { return _masterVolume; }

            set
            {
                _masterVolume = value;
                ComputeVolume();
            }
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
            get
            {
                return _sound.WaveSource.GetPosition() > _sound.WaveSource.GetLength() ? 
                    _sound.WaveSource.GetLength() : 
                    _sound.WaveSource.GetPosition();
            }
        }

        public int PositionPercentage
        {
            get { return Math.Min((int)Math.Round(Position.TotalSeconds/Lenght.TotalSeconds*PercentageConst), PercentageConst);  }
            set
            {
                var valueInSecond = (int)((float) value/ PercentageConst * Lenght.TotalSeconds);
                _sound.WaveSource.SetPosition(new TimeSpan(0, 0, valueInSecond));
            }
        }

        public TimeSpan Lenght
        {
            get { return _sound.WaveSource.GetLength(); }
        }

        public TimeSpan TimeRemaining
        {
            get { return Lenght - Position; }
        }

        public bool Finshed
        {
            get { return Position == Lenght; }
        }

		private void ComputeVolume()
		{
		    float volume = ((float) _volume/100)*((float) _masterVolume/100);
			_sound.Volume = volume;
            Debug.WriteLine("Volume: " + volume);
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
            Equalizer.Dispose();
        }
    }
}
