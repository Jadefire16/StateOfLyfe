using UnityEngine;

namespace SOL.Management
{
    public abstract class StateController : MonoBehaviour
    {
        public abstract StateMachine StateMachine { get; }

        /// <summary>
        /// Initializes the <see cref="StateController"/> and its dependencies.
        /// </summary>
        /// <remarks>
        /// This will have some impact during runtime if too many things are being initialized.
        /// </remarks>
        protected abstract void Initalize();
        /// <summary>
        /// For termination of the <see cref="StateController"/> and its subsequent components.
        /// </summary>
        protected abstract void Decommission();
        /// <summary>
        /// Used to pass Unity's messages to the StateMachine and to handle other StateController specific logic
        /// </summary>
        protected abstract void Tick<T>(double time, T tickType);


        /// <summary>
        /// Unity's built in Awake Method
        /// </summary>
        /// <inheritdoc cref="Awake"/>
        protected abstract void Awake();
        /// <summary>
        /// Unity's built in Start Method
        /// </summary>
        /// <inheritdoc cref="Start"/>
        protected abstract void Start();
        /// <summary>
        /// Unity's built in Update Method
        /// </summary>
        /// <inheritdoc cref="Update"/>
        protected abstract void Update();
        /// <summary>
        /// Unity's built in LateUpdate Method
        /// </summary>
        /// <inheritdoc cref="LateUpdate"/>
        protected abstract void LateUpdate();
        /// <summary>
        /// Unity's built in FixedUpdate Method
        /// </summary>
        /// <inheritdoc cref="FixedUpdate"/>
        protected abstract void FixedUpdate();
        



    }
}
