using System;
using DJ.Core.Context;
using DJ.Core.Controllers.Interfaces;
using DJ.Core.Observers;

namespace DJ.Core.Controllers
{
    public class TrackController : BaseController, ITrackController
    {
        private readonly ITrackObserver _observer;

        public TrackController(ITrackObserver observer, AppContext context) : base(context) 
        {
            _observer = observer;
        }

        public void Play()
        {
            Console.WriteLine("play");
            _observer.SetSpektrum(20);
        }

        public void Cue()
        {
            throw new NotImplementedException();
        }

        public void Stop()
        {
            throw new NotImplementedException();
        }

        public void SetVolume(uint volume)
        {
            _observer.SetSpektrum(volume * 10);
        }

        public void SetTime(uint time)
        {
            throw new NotImplementedException();
        }

        public bool Loop { set; private get; }
    }
}
