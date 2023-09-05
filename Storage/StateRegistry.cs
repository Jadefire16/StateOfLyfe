using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOL
{
    public abstract class StateRegistry : IStateRegistry<IState>
    {
        public abstract void ClearRegistry();
        public abstract bool RegisterState(IState state);
        public abstract bool UnregisterState(IState state);
        public abstract bool SetCurrentState(IState state);
    }
}
