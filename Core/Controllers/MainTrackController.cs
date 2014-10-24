using DJ.Core.Audio;
using DJ.Core.Context;

namespace DJ.Core.Controllers
{
    public class MainTrackController : TrackController
    {
        public MainTrackController(AppContext context) : base(context)
        {
            context.MainTrackController = this;
        }

        public void Next()
        {
            var next = Context.Playlist.NextItem;
            if (next != null)
            {
                LoadTrack(next);
                Track.Play();
            }
            else
            {
                Track = null;
            }
        }

        protected override AudioMaterial Track
        {
            set { Context.MainTrack = value; }
            get { return Context.MainTrack; }
        }

        protected override void TrackFinshed()
        {
            base.TrackFinshed();
            Next();
        }
    }
}