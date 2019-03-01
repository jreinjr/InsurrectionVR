using UnityEngine;
using System.Collections;
using System.Collections.Generic;

namespace InsurrectionVR
{
    public abstract class InputHandler : ScriptableObject
    {
        // Output Variables
        [HideInInspector] public float Horizontal { get; protected set; }
        [HideInInspector] public float Vertical { get; protected set; }
        [HideInInspector] public float MouseX { get; protected set; }
        [HideInInspector] public float MouseY { get; protected set; }
        [HideInInspector] public float Jump { get; protected set; }
        [HideInInspector] public float Strafe { get; protected set; }
        [HideInInspector] public float Sprint { get; protected set; }

        // Output Bools
        [HideInInspector] public bool HasAnyInput { get; protected set; }
        [HideInInspector] public bool HasHorizontalInput { get; protected set; }
        [HideInInspector] public bool HasVerticalInput { get; protected set; }
        [HideInInspector] public bool HasMouseXInput { get; protected set; }
        [HideInInspector] public bool HasMouseYInput { get; protected set; }
        [HideInInspector] public bool HasJumpInput { get; protected set; }
        [HideInInspector] public bool HasStrafeInput { get; protected set; }
        [HideInInspector] public bool HasSprintInput { get; protected set; }

        /// <summary>
        ///  Updates bools - override this at the end of child methods
        /// </summary>
        public virtual void ReadInput()
        {
            UpdateOutputBools();
        }

        protected virtual void UpdateOutputBools()
        {
            HasHorizontalInput = HasAxisInput(Horizontal);
            HasVerticalInput = HasAxisInput(Vertical);
            HasMouseXInput = HasAxisInput(MouseX);
            HasMouseYInput = HasAxisInput(MouseY);
            HasJumpInput = HasAxisInput(Jump);
            HasStrafeInput = HasAxisInput(Strafe);
            HasSprintInput = HasAxisInput(Sprint);

            HasAnyInput = HasHorizontalInput
                       || HasVerticalInput
                       || HasMouseXInput
                       || HasMouseYInput
                       || HasJumpInput
                       || HasStrafeInput
                       || HasSprintInput
                       ;
        }

        protected bool HasAxisInput(float axis)
        {
            return Mathf.Abs(axis) > Mathf.Epsilon;
        }
    }
}
