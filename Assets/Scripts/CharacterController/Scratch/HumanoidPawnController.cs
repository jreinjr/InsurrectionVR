using UnityEngine;
using System.Collections;

namespace InsurrectionVR
{
    public class HumanoidPawnController : PawnController
    {
        // Temporary until we get everything integrated
        public jThirdPersonController cc;

        protected override void HandleInput()
        {
            if (input.HasHorizontalInput || input.HasVerticalInput)
                Move();

            if (input.HasJumpInput)
                Jump();

            if (input.HasStrafeInput)
                Strafe();

            cc.UpdateMotor();
            cc.UpdateAnimator();
        }

        protected void Move()
        {
            Debug.LogFormat("Humanoid moving ({0}, {1})", input.Horizontal, input.Vertical);
            cc.input.x = input.Horizontal;
            cc.input.y = input.Vertical;
        }

        protected void Jump()
        {
            Debug.Log("Humanoid Jump: " + input.Jump);
            cc.Jump();
        }

        protected void Strafe()
        {
            Debug.Log("Humanoid Strafe: " + input.Strafe);
            cc.Strafe();
        }
    }
}
