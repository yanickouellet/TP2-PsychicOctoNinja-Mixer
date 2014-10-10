using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DJ.Core.Observers;

namespace DJ.Core.Controllers.Interfaces
{
    public interface IMainController
    {
        ITrackController CreateMainTrackController(ITrackObserver observer);

        ITrackController CreateSecondTrackController(ITrackObserver observer);

        ITrackController CreatePlaylistController(ITrackObserver observer);

        ITrackController CreateExplorerController(ITrackObserver observer);
    }
}
