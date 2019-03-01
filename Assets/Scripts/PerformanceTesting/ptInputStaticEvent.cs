using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ptInputStaticEvent : MonoBehaviour
{
    public static Action<float> OnHorizontalInput = delegate { };

    public string HorizontalAxis = "Horizontal";
    private float HorizontalInput;

    public void Update()
    {
        HorizontalInput = Input.GetAxis(HorizontalAxis);
        OnHorizontalInput(HorizontalInput);
    }
}
