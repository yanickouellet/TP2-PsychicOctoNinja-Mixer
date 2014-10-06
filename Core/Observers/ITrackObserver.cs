using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DJ.Core.Observers
{
    public interface ITrackObserver
    {
        //TODO Change to user real spektrum analyzer
        void SetSpektrum(uint level);
    }
}
