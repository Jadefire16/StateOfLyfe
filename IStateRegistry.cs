using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOL
{
    public interface IStateRegistry<TState>
    {
        bool RegisterState(TState state);
        bool UnregisterState(TState state);
        void ClearRegistry();
    }
}
