using DJ.Core.Audio;
using DJ.Core.Context;

namespace DJ.Core.Controllers
{
    public class MainTrackController : TrackController
    {
        public MainTrackController(AppContext context) : base(context)
        {
        }

        protected override AudioMaterial Track
        {
            set { Context.MainTrack = value; }
            get { return Context.MainTrack; }
        }

        protected override void TrackFinshed()
        {
            base.TrackFinshed();

            var next = Context.Playlist.NextItem;
            if (next != null)
            {
                LoadTrack(next.AudioFile.Name);
                Track.Play();
            }
            else
            {
                Track = null;
            }
        }
    }
}