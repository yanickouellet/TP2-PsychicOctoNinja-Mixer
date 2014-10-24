using System;
using DJ.Core.Events;

namespace DJ.Core.Controllers.Interfaces
{
    public interface IMainController
    {
        ITrackController CreateMainTrackController();

        ITrackController CreateSecondTrackController();

        IPlaylistController CreatePlaylistController();
        void Dispose();

		void ChangeMasterVolume(int volume);
        void PlayNext();
		event EventHandler<VolumeChangedEventArgs> RaiseVolumeChangedEvent; 
    }
}
