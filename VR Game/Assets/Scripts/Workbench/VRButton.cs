using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VRButton : MonoBehaviour
{
    public bool IsPressed { get; protected set; }

    public event Action Pressed;

    public event Action Unpressed;


    void OnTriggerEnter(Collider other)
    {
        Pressed?.Invoke();
        IsPressed = true;
    }

    void OnTriggerExit(Collider other)
    {
        Unpressed?.Invoke();
        IsPressed = false;
    }
}
