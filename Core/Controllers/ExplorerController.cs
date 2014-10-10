using System;
using DJ.Core.Context;
using DJ.Core.Controllers.Interfaces;

namespace DJ.Core.Controllers
{
    public class ExplorerController : BaseController, IExplorerController
    {

        public ExplorerController(AppContext context) : base(context) 
        {
        }
    }
}
