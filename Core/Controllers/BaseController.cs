using System;
using DJ.Core.Context;

namespace DJ.Core.Controllers
{
    public class BaseController
    {
        private readonly AppContext _context;

        protected AppContext Context 
        {
            get { return _context; }
        }

        public BaseController(AppContext context)
        {
            _context = context;
        }

        protected virtual void OnRaiseEvent<T>(T e, EventHandler<T> handler, Action<T> doBeforeEvent = null) where T : EventArgs
        {
            if (handler != null)
            {
                if (doBeforeEvent != null)
                    doBeforeEvent(e);
                handler(this, e);
            }
        }
    }
}
