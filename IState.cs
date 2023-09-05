using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOL
{
    public interface IState : IInitializable
    {
        void OnEnter();
        void OnExit(); 
    }
}

///Todo: Might be able to refactor this and leave IState as an empty interface for people to implement
