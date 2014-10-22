using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DJ.Core.Controllers.Interfaces
{
    public interface IMainController
    {
        ITrackController CreateMainTrackController();

        ITrackController CreateSecondTrackController();

        IPlaylistController CreatePlaylistController();
        void Dispose();
    }
}
