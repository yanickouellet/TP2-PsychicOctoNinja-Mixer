using System.Timers;
using DJ.Core.Audio;
using DJ.Core.Controllers;

namespace DJ.Core.Context
{
    public class AppContext : IContext
    {
        public AudioMaterial MainTrack { get; set; }
        public AudioMaterial SecondaryTrack { get; set; }
        public Playlist Playlist { get; set; }
        public MainTrackController MainTrackController { get; set; }
		
		private int _masterVolume;
        private readonly Timer _timer;

        public AppContext()
        {
            Playlist = new Playlist();
            _timer = new Timer(500);
            _timer.Start();
        }

        public int MasterVolume
        {
            get { return _masterVolume; }

            set
            {
                _masterVolume = value;

                if (MainTrack != null)
                    MainTrack.MasterVolume = _masterVolume;

                if (SecondaryTrack != null)
                    SecondaryTrack.MasterVolume = _masterVolume;
            }
        }

        public void AddEventOnTick(ElapsedEventHandler handler)
        {
            _timer.Elapsed += handler;
        }
    }
}
