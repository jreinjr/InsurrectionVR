using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ptControllerInVars : MonoBehaviour
{
    public ptInputOutVars input;

    // Update is called once per frame
    void Update()
    {
        input.ReadInput();
        transform.Translate(Vector3.right * input.HorizontalInput);
    }
}
