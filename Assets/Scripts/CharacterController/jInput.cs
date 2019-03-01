using UnityEngine;

namespace InsurrectionVR
{
    public abstract class jInput : MonoBehaviour
    {
        protected jThirdPersonController cc;                // access the ThirdPersonController component                

        protected virtual void Start()
        {
            ControllerInit();
        }

        protected virtual void ControllerInit()
        {
            cc = GetComponent<jThirdPersonController>();
            if (cc != null)
                cc.Init();
        }

        protected virtual void LateUpdate()
        {
            if (cc == null) return;             // returns if didn't find the controller		    
            InputHandle();                      // update input methods
        }

        protected virtual void FixedUpdate()
        {
            cc.AirControl();
        }

        protected virtual void Update()
        {
            cc.UpdateMotor();                   // call ThirdPersonMotor methods               
            cc.UpdateAnimator();                // call ThirdPersonAnimator methods		               
        }

        protected virtual void InputHandle()
        {
            if (!cc.lockMovement)
            {
                MoveCharacter();
            }
        }


        #region Basic Locomotion Inputs      

        protected abstract void MoveCharacter();

        #endregion

    }
}

