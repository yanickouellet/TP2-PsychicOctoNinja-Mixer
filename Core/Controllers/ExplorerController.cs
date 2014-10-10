using System;
using DJ.Core.Context;
using DJ.Core.Controllers.Interfaces;
using DJ.Core.Observers;

namespace DJ.Core.Controllers
{
    public class ExplorerController : BaseController, IExplorerController
    {
        private readonly IExplorerObserver _observer;

        public ExplorerController(IExplorerObserver observer, AppContext context) : base(context) 
        {
            _observer = observer;
        }
    }
}
