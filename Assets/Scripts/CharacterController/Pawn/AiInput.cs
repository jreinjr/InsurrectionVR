using UnityEngine;

public class AiInput : IPawnInput
{
    // Derived variables
    private Vector3 input_direction = Vector3.zero;
    private float input_rotation;
    private bool input_jump;


    // Public output variables
    public Vector3 DirectionInput { get { return input_direction; } }
    public float RotationInput { get { return input_rotation; } }
    public bool JumpInput { get { return input_jump; } }

    public void ReadInput()
    {
        input_rotation = Random.Range(-1, 1);
    }
}