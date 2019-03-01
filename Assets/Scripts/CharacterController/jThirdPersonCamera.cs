using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Invector.CharacterController;

public class jThirdPersonCamera : vThirdPersonCamera
{
    public float TARGETING_MODE_OFFSET = 0.3f;

    public void SetTargetingMode(bool enabled)
    {
        rightOffset = enabled ? TARGETING_MODE_OFFSET : 0; 
    }

}
