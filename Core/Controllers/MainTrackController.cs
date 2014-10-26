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

        protected override AudioMaterial Track
        {
            set { Context.MainTrack = value; }
            get { return Context.MainTrack; }
        }

        protected override void TrackFinshed()
        {
            base.TrackFinshed();
            //Next();
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