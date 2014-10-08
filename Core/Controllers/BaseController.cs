using DJ.Core.Context;

namespace DJ.Core.Controllers
{
    public class BaseController
    {
        private readonly IContext _context;
        protected IContext Context 
        {
            get { return _context; }
        }

        public BaseController(IContext context)
        {
            _context = context;
        }
    }
}
