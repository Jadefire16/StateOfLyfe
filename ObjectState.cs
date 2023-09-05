using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOL
{
    public enum ObjectState
    {
        Inactive = 0,
        Initializing = 1,
        Active = 2,
        Decommissing = 3,
        Decommissioned = 4
    }
}
