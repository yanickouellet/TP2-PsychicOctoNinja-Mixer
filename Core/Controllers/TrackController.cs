using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DJ.Core.Controllers.Interfaces;
using DJ.Core.Observers;

namespace DJ.Core.Controllers
{
    public class TrackController : ITrackController
    {
        private readonly ITrackObserver _observer;

        public TrackController(ITrackObserver observer)
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
            _observer.SetSpektrum(volume);
        }

        public void SetTime(uint time)
        {
            throw new NotImplementedException();
        }

        public bool Loop { set; private get; }
    }
}
