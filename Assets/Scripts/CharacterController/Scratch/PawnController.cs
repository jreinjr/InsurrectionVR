using UnityEngine;

namespace InsurrectionVR
{
    /// <summary>
    /// The controller has a list of inputs (currently one)
    /// that it weighs and processes (TODO) to determine its actions.
    /// The controller only calls the relevant systems,
    /// it shouldn't move the object itself
    /// </summary>
    public abstract class PawnController : MonoBehaviour
    {
        [SerializeField] [Expandable] protected InputHandler input;

        protected virtual void Update()
        {
            if (input)
            {
                ReadInput();

                if (input.HasAnyInput)
                    HandleInput();
            }
        }

        protected virtual void ReadInput()
        {
            input.ReadInput();
        }


        protected abstract void HandleInput();
    }
}