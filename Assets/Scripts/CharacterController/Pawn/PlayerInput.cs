using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInput : IPawnInput
{
    // Dependencies
    private PawnInputControls controls;

    // Input variables
    private float input_horizontal = 0;
    private float input_vertical = 0;
    private float input_strafe = 0;
    private bool input_jump;

    // Derived variables
    private Vector3 input_direction;
    private float input_rotation;

    // Public output variables
    public Vector3 DirectionInput { get { return input_direction; } }
    public float RotationInput { get { return input_rotation; } }
    public bool JumpInput { get { return input_jump; } }

    public PlayerInput(PawnInputControls controls)
    {
        // Dependency injection
        this.controls = controls;
    }

    public void ReadInput()
    {
        input_horizontal = Input.GetAxis(controls.horizontalAxis);
        input_vertical = Input.GetAxis(controls.verticalAxis);
        input_strafe = Input.GetAxis(controls.strafeAxis);
        input_jump = Input.GetButtonDown(controls.jumpButton);
    }
}
