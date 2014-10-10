using DJ.Core.Context;
using DJ.Core.Controllers.Interfaces;

namespace DJ.Core.Controllers
{
    public class MainController : IMainController
    {
        private readonly AppContext _appContext;

        public MainController()
        {
            _appContext = new AppContext();
        }

        public ITrackController CreateMainTrackController()
        {
            return new MainTrackController(_appContext);
        }

        public ITrackController CreateSecondTrackController()
        {
            return new SecondaryTrackController(_appContext);
        }

        public void Dispose()
        {
            if(_appContext.MainTrack != null)
                _appContext.MainTrack.Dispose();
            if(_appContext.SecondaryTrack != null)
                _appContext.SecondaryTrack.Dispose();
        }
    }
}
