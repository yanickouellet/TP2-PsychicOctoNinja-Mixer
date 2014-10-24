using System.Timers;
using DJ.Core.Audio;
using DJ.Core.Controllers;

namespace DJ.Core.Context
{
    public interface IContext
    {
        AudioMaterial MainTrack { get; set; }
        AudioMaterial SecondaryTrack { get; set; }

		int MasterVolume { get; set; }
        Playlist Playlist { get; set; }
        // Some controllers may need to change the first track, but to do so, they must let
        // the MainTrackController do the job, so they need to access it and call it from  the context
        MainTrackController MainTrackController { get; set; }

        void AddEventOnTick(ElapsedEventHandler handler);
    }
}
