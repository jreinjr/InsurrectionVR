using UnityEngine;
using System.Collections;
using System.Collections.Generic;

namespace InsurrectionVR
{
    [CreateAssetMenu(menuName = "Input/Player Input Handler")]
    public class PlayerInputHandler : InputHandler
    {
        [SerializeField] [Expandable] private InputFloat HorizontalInput;
        [SerializeField] [Expandable] private InputFloat VerticalInput;
        [SerializeField] [Expandable] private InputFloat MouseXInput;
        [SerializeField] [Expandable] private InputFloat MouseYInput;
        [SerializeField] [Expandable] private InputFloat JumpInput;
        [SerializeField] [Expandable] private InputFloat StrafeInput;

        public override void ReadInput()
        {
            ValidateInputFloats();
            ReadAxisInputs();
            
            // Override base at the end to update bools
            base.ReadInput();
        }

        protected void ReadAxisInputs()
        {
            Horizontal = HorizontalInput.Value;
            Vertical   = VerticalInput.Value;
            MouseX     = MouseXInput.Value;
            MouseY     = MouseYInput.Value;
            Jump       = JumpInput.Value;
            Strafe     = StrafeInput.Value;
        }

        protected float GetAxisInput(InputFloat input)
        {
            return  input.isAxis ?
                    Input.GetAxis(input.AxisString) :
                    Input.GetKey(input.KeyCode) ? 1 : 0;
        }

        /// <summary>
        /// Ensures all required inputs are hooked up in the inspector
        /// </summary>
        protected bool ValidateInputFloats()
        {
            if (!HorizontalInput
             || !VerticalInput
             || !MouseXInput
             || !MouseYInput
             || !JumpInput
             || !StrafeInput)
            {
                Debug.LogErrorFormat("At least one input is not connected in the inspector for {0}", this.name);
                return false;
            }

            else return true;
        }
    }
}
