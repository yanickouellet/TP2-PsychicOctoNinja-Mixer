using System;
using System.Timers;
using DJ.Core.Audio;
using DJ.Core.Context;
using DJ.Core.Events;
using DJ.Core.Transitions;

namespace DJ.Core.Controllers
{
    public class MainTrackController : TrackController
    {
        private AbstractTransition _transition;
        private bool _transitionStarted = false;
        private int _transitionDuration;
        public MainTrackController(AppContext context) : base(context)
        {
            context.MainTrackController = this;
            _transition = null;
            _transitionStarted = false;
            _transitionDuration = 10;
            Context.AddEventOnTick(TickHandler);
        }

        public void Next()
        {
            StartTransition(Context.Playlist.NextItem);
        }

        public override void Play()
        {
            base.Play();
            if(_transition != null)
                _transition.ContinueToPlay();
        }

        public override void Cue()
        {
            base.Cue();
            if(_transition != null)
                _transition.Pause();
        }

        public override void SetTime(int time)
        {
            base.SetTime(time);
            if(_transition != null)
                CancelTransition();
        }

        public override void Stop()
        {
            base.Stop();
            if(_transition != null)
                CancelTransition();
        }

        protected override AudioMaterial Track
        {
            set { Context.MainTrack = value; }
            get { return Context.MainTrack; }
        }

        private void StartTransition(MusicItem item)
        {
            AudioMaterial nextTrack = null;
            if (item != null)
            {
                nextTrack = new AudioMaterial(item);
                nextTrack.MasterVolume = Context.MasterVolume;
            }
            _transition = new LinearTransition(nextTrack, Context.MainTrack);
            _transition.StartTransition((int)Context.MainTrack.TimeRemaining.TotalSeconds);
        }

        private void CancelTransition()
        {
            _transition.CancelTransition();
            _transition = null;
            _transitionStarted = false;
        }

        private void TickHandler(object sender, ElapsedEventArgs elapsedEventArgs)
        {
            if (_transition != null)
            {
                _transition.DoStep();
                if (_transition.Finished)
                {
                    Context.MainTrack = _transition.TrackToPlay;
                    RaiseTrackChangedEvent(new TrackChangedEventArgs(Context.MainTrack.Item));
                    _transition = null;
                    _transitionStarted = false;
                }
            }
            else if (!_transitionStarted && Context.MainTrack != null && Context.MainTrack.TimeRemaining.TotalSeconds <= _transitionDuration)
            {
                _transitionStarted = true;
                Next();
            }
        }
    }
}