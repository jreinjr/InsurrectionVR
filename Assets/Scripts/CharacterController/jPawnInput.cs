using UnityEngine;

namespace InsurrectionVR
{
    public abstract class jPawnInput : jInput
    {
        protected jThirdPersonController cc;                // access the ThirdPersonController component                

        protected virtual void Start()
        {
            ControllerInit();
        }

        protected override void InputHandle()
        {
            base.InputHandle();

            if (!cc.lockMovement)
            {
                SprintInput();
                StrafeInput();
                JumpInput();
            }
        }

        #region Basic Locomotion Inputs      

        protected abstract void StrafeInput();

        protected abstract void SprintInput();

        protected abstract void JumpInput();

        #endregion

    }
}

