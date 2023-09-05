using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using SOL.Processing;
using SOL.Interfacing;

namespace SOL.Management
{
    public abstract class StateMachine
    {
        /// <summary>
        /// Gets the <see cref="ObjectState"/> of the <see cref="StateMachine"/>.
        /// </summary>
        /// <remarks>Decommissioned or Decommissioning <see cref="StateMachine"/>s should throw when properties or methods are accessed.</remarks>
        public abstract ObjectState ActiveState { get; }

        /// <summary>
        /// Gets the <see cref="IStateRegistry{TState}"/> bound to the <see cref="StateMachine"/>.
        /// </summary>
        public abstract IStateRegistry<IState> StateRegistry { get; }

        /// <summary>
        /// Gets the <see cref="IProcessor{TState}"/> bound to the <see cref="StateMachine"/>.
        /// </summary>
        /// <remarks>Generally referred to as the State Processor.<br/>
        /// The processor handles the processing and updating of states.</remarks>
        public abstract IProcessor<IState> Processor { get; }

        /// <summary>
        /// Gets the <see cref="IListener"/> bound to the <see cref="StateMachine"/>.
        /// </summary>
        public abstract IListener Listener { get; } // Todo: Should the Listener listen to outside events or internal events like the states themselves?

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
        public abstract void Tick<T>(double time, T tickType) where T : struct;
        /// <summary>
        /// Should reset the internal state of the <see cref="StateMachine"/> to prepare it for another cycle.
        /// </summary>
        public abstract void Reset();
    }
}