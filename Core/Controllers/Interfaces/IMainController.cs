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

        bool RepeatPlaylist { get; set; }
        bool Random { get; set; }
        int TransitionDuration { get; set; }
		event EventHandler<VolumeChangedEventArgs> RaiseVolumeChangedEvent; 
    }
}
