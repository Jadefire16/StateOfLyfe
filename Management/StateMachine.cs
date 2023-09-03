using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SOL.Management
{
    public abstract class StateMachine
    {
        /// <summary>
        /// Gets the <see cref="ObjectState"/> of the <see cref="StateMachine"/>.
        /// </summary>
        /// <remarks>Decommissioned <see cref="StateMachine"/>s should throw when properties or methods are accessed.</remarks>
        public abstract ObjectState ActiveState { get; }

        /// <summary>
        /// Initializes the <see cref="StateMachine"/>.
        /// </summary>
        public abstract void Initialize();
        /// <summary>
        /// For termination of the <see cref="StateMachine"/> and its subsequent components.
        /// </summary>
        public abstract void Decommission();
        /// <summary>
        /// Calls the update methods in the <see cref="StateMachine"/>.
        /// </summary>
        public abstract void Tick<T>(double time, T tickType);
    }
}