using System;
using DJ.Core.Context;
using DJ.Core.Controllers.Interfaces;
using DJ.Core.Observers;

namespace DJ.Core.Controllers
{
    public class PlaylistController : BaseController, IPlaylistController
    {
        private readonly IPlaylistObserver _observer;

        public PlaylistController(IPlaylistObserver observer, AppContext context) : base(context) 
        {
            _observer = observer;
        }
    }
}
