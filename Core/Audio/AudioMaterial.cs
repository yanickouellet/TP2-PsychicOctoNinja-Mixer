﻿using System;
using CSCore;
using CSCore.Codecs;
using CSCore.SoundOut;
using System.Diagnostics;

namespace DJ.Core.Audio
{
    public class AudioMaterial : IDisposable
    {
        private IWaveSource _source;
        private ISoundOut _sound;
        private string _filename;
		private int _masterVolume;
		private int _volume;

		public int MasterVolume
		{
			get
			{
				return _masterVolume;
			}

			set
			{
				_masterVolume = value;
				ComputeVolume();
			}
		}

        public AudioMaterial(string filename)
        {
            _filename = filename;
            _source = CodecFactory.Instance.GetCodec(filename);
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
