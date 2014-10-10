using DJ.Core.Audio;
using DJ.Core.Context;

namespace DJ.Core.Controllers
{
    public class SecondaryTrackController : TrackController
    {
        public SecondaryTrackController(AppContext context) : base(context)
        {
        }

        protected override AudioMaterial Track
        {
            get { return Context.SecondaryTrack; }
        }
    }
}