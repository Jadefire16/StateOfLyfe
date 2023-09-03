using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOL
{
    [Flags]
    enum UpdateLoopType
    {
        Invalid = 0,
        EarlyTick = 1,
        Tick = 2,
        FixedTick = 4,
        LateTick = 8,
    }
}
