using UnityEngine;
using System.Collections;
using Invector.CharacterController;

namespace InsurrectionVR
{
    public class HumanoidPawnController : PawnController
    {
        // Temporary until we get everything integrated
        public vThirdPersonController cc;
        protected vThirdPersonCamera tpCamera;                // acess camera info      
        [HideInInspector]
        public bool keepDirection;                          // keep the current direction in case you change the cameraState
        public PawnController target;


        protected void Start()
        {
            Init();
            if(input)
                StartCoroutine(ControlAfter3Sec());
        }

        IEnumerator ControlAfter3Sec()
        {
            yield return new WaitForSeconds(3f);
            Debug.Log("controlling");
            var mc = new MindControlAbility();
            mc.Cast(this, target);
        }

        protected virtual void FixedUpdate()
        {
            if (!input)
                return;
            cc.AirControl();
            CameraInput();  // read more about this below
        }

        protected virtual void Update()
        {
            cc.UpdateMotor();
            cc.UpdateAnimator();
        }

        protected virtual void LateUpdate()
        {
            if (cc == null) return;              

            if (input)
            {
                ReadInput();

                if (input.HasAnyInput)
                    HandleInput();
            }
        }

        protected void Init()
        {
            cc = GetComponent<vThirdPersonController>();
            if (cc != null)
                cc.Init();

            tpCamera = FindObjectOfType<vThirdPersonCamera>();
            if (tpCamera) tpCamera.SetMainTarget(this.transform);
        }
        
        protected override void HandleInput()
        {
            CameraInput();

            if (!cc.lockMovement)
            {
                Move();
                Strafe();
                Jump();
            }
        }

        protected void Move()
        {
            cc.input.x = input.Horizontal;
            cc.input.y = input.Vertical;
        }

        protected void Jump()
        {
            if (input.HasJumpInput)
            {
                cc.Jump();
            }
        }

        protected void Strafe()
        {
            if (input.HasStrafeInput)
            {
                cc.Strafe();
            }
        }

        protected void Sprint()
        {
            if (input.HasSprintInput)
            {
                cc.Sprint(input.Sprint > Mathf.Epsilon);
            }
        }

        protected virtual void CameraInput()
        {
            if (tpCamera == null)
                return;
            var Y = input.MouseY;
            var X = input.MouseX;

            tpCamera.RotateCamera(X, Y);

            // tranform Character direction from camera if not KeepDirection
            // UpdateTargetDirection is the key method here
            // Everything else lerps the camera smoothly when strafe is toggled
            // or rotates you with the camera when it should be fixed.
            if (!keepDirection)
                cc.UpdateTargetDirection(tpCamera != null ? tpCamera.transform : null);
            // rotate the character with the camera while strafing        
            RotateWithCamera(tpCamera != null ? tpCamera.transform : null);
        }

        protected virtual void RotateWithCamera(Transform cameraTransform)
        {
            if (cc.isStrafing && !cc.lockMovement && !cc.lockMovement)
            {
                cc.RotateWithAnotherTransform(cameraTransform);
            }
        }
    }
}
