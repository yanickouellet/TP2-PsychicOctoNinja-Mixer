using System;
using DJ.Core.Audio;
using TagLib.Matroska;

namespace DJ.Core.Transitions
{
    public class LinearTransition : AbstractTransition
    {
        protected double VolumeByStep;
        public LinearTransition(AudioMaterial trackToPlay, AudioMaterial trackToStop) : base(trackToPlay, trackToStop)
        {
        }

        protected override void PrepareToStart()
        {
            VolumeByStep = Math.Floor((float)TargetVolume / StepNumber);
        }

        protected override void InternalDoStep()
        {
            if(TrackToPlay != null)
                TrackToPlay.Volume += (int)Math.Ceiling(VolumeByStep);
            TrackToStop.Volume -= (int)Math.Floor(VolumeByStep);
        }
    }
}
