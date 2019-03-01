using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ptControllerListener : MonoBehaviour
{
    private void OnEnable()
    {
        ptInputStaticEvent.OnHorizontalInput += MoveHorizontal;
    }

    private void OnDisable()
    {
        ptInputStaticEvent.OnHorizontalInput -= MoveHorizontal;
    }

    void MoveHorizontal(float f)
    {
        transform.Translate(Vector3.right * f);
    }
}
