﻿using System;
using DJ.Core.Audio;
using TagLib.Matroska;

namespace DJ.Core.Transitions
{
    public abstract class AbstractTransition
    {
        private bool _inPause;
        protected int StepNumber { get; set; }
        protected int ActuelSetp { get; set; }
        protected int TargetVolume { get; set; }
        public AudioMaterial TrackToPlay { get; private set; }
        public AudioMaterial TrackToStop { get; private set; }
        public bool Finished { get; set; }

        public AbstractTransition(AudioMaterial trackToPlay, AudioMaterial trackToStop)
        {
            if(trackToStop == null)
                throw new ArgumentNullException("trackToStop");

            TrackToPlay = trackToPlay;
            TrackToStop = trackToStop;
            StepNumber = 0;
            ActuelSetp = 0;
            TargetVolume = 0;
            _inPause = false;
            Finished = false;
        }

        public virtual void StartTransition(int duration)
        {
            if(TrackToPlay != null && duration > TrackToPlay.Lenght.TotalSeconds)
                throw new ArgumentException("Duration is too long for the track length", "duration");

            StepNumber = 2*duration;
            ActuelSetp = 0;
            TargetVolume = TrackToStop.Volume;
            PrepareToStart();

            if(TrackToPlay != null)
                TrackToPlay.Play();
            DoStep();
        }

        public virtual void Pause()
        {
            _inPause = true;
            TrackToPlay.Pause();
            TrackToStop.Pause();
        }

        public virtual void ContinueToPlay()
        {
            _inPause = false;
            TrackToPlay.Play();
            TrackToStop.Play();
        }

        public virtual void DoStep()
        {
            if (_inPause)
                return;
            ActuelSetp++;
            InternalDoStep();
            if (ActuelSetp == StepNumber)
            {
                TransitionFinished();
            }
        }

        public virtual void CancelTransition()
        {
            TrackToPlay.Dispose();
        }

        protected virtual void TransitionFinished()
        {
            Finished = true;
            if(TrackToPlay != null)
                TrackToPlay.Volume = TargetVolume;
            TrackToStop.Dispose();
        }

        protected abstract void PrepareToStart();
        protected abstract void InternalDoStep();
    }
}
