using DJ.Core.Context;
using DJ.Core.Controllers.Interfaces;
using DJ.Core.Observers;

namespace DJ.Core.Controllers
{
    public class MainController : IMainController
    {
        private readonly AppContext _appContext;

        public MainController()
        {
            _appContext = new AppContext();
        }

        public ITrackController CreateMainTrackController(ITrackObserver observer)
        {
            return new TrackController(observer, _appContext);
        }

        public ITrackController CreateSecondTrackController(ITrackObserver observer)
        {
            return new TrackController(observer, _appContext);
        }
    }
}
