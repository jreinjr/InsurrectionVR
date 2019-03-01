using UnityEngine;

public interface IPawnInput
{
    Vector3 DirectionInput { get; }
    float RotationInput { get; }
    bool JumpInput { get; }

    void ReadInput();
}