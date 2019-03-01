using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ptInputOutVars : MonoBehaviour
{
    public string HorizontalAxis = "Horizontal";
    public float HorizontalInput;

    public void ReadInput()
    {
        HorizontalInput = Input.GetAxis(HorizontalAxis);
    }

}
