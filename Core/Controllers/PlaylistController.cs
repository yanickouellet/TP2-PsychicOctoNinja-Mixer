using System;
using DJ.Core.Audio;
using DJ.Core.Context;
using DJ.Core.Controllers.Interfaces;

namespace DJ.Core.Controllers
{
    public class PlaylistController : BaseController, IPlaylistController
    {

        public PlaylistController(AppContext context) : base(context) 
        {
        }

        public Playlist Playlist { get { return Context.Playlist; } }
    }
}
