using DJ.Core.Context;
using DJ.Core.Controllers.Interfaces;
using DJ.Core.Events;
using System;

namespace DJ.Core.Controllers
{
    public class MainController : BaseController, IMainController
    {
        private readonly AppContext _appContext;

        public MainController(): base(new AppContext())
        {
			_appContext = Context as AppContext;
        }

        public ITrackController CreateMainTrackController()
        {
            return new MainTrackController(_appContext);
        }

        public ITrackController CreateSecondTrackController()
        {
            return new SecondaryTrackController(_appContext);
        }

        public IPlaylistController CreatePlaylistController()
        {
            return new PlaylistController(_appContext);
        }

        public void Dispose()
        {
            if(_appContext.MainTrack != null)
                _appContext.MainTrack.Dispose();
            if(_appContext.SecondaryTrack != null)
                _appContext.SecondaryTrack.Dispose();
        }

		public void ChangeMasterVolume(int volume)
		{
			_appContext.MasterVolume = volume;
			OnRaiseEvent<VolumeChangedEventArgs>(new VolumeChangedEventArgs(volume), RaiseVolumeChangedEvent);
		}

        public void PlayNext()
        {
            Context.MainTrackController.Next();
        }

		public event EventHandler<VolumeChangedEventArgs> RaiseVolumeChangedEvent;
    }
}
