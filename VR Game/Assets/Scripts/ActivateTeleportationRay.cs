using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class ActivateTeleportationRay : MonoBehaviour
{
    [SerializeField] GameObject leftTeleportation;
    [SerializeField] GameObject rightTeleportation;

    [SerializeField] InputActionProperty leftActivate;
    [SerializeField] InputActionProperty rightActivate;

    [SerializeField] InputActionProperty leftCancel;
    [SerializeField] InputActionProperty rightCancel;

    void Update()
    {
        leftTeleportation.SetActive(leftCancel.action.ReadValue<float>() == 0 && leftActivate.action.ReadValue<float>() > 0.025f);
        rightTeleportation.SetActive(rightCancel.action.ReadValue<float>() == 0 && rightActivate.action.ReadValue<float>() > 0.025f);
    }
}
