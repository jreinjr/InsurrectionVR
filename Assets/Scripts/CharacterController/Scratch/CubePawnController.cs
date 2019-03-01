using UnityEngine;
using System.Collections;

namespace InsurrectionVR
{
    public class CubePawnController : PawnController
    {
        protected override void HandleInput()
        {
            if (input.HasHorizontalInput || input.HasVerticalInput)
                Move();

            if (input.HasJumpInput)
                Jump();
        }

        protected void Move()
        {
            Debug.LogFormat("Cube moving ({0}, {1})", input.Horizontal, input.Vertical);
        }

        protected void Jump()
        {
            Debug.Log("Cube Jumping: " + input.Jump);
        }
    }
}
