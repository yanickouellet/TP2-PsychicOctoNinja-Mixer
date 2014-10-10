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
            get { return Context.MainTrack; }
        }
    }
}