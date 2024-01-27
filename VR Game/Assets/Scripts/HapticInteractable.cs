using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;
using System;

[Serializable]
public class Haptic
{
    [Range(0, 1)]
    [SerializeField] float intensity;
    [SerializeField] float duration;

    public void TriggerHaptic(BaseInteractionEventArgs eventArgs)
    {
        if (eventArgs.interactorObject is XRBaseControllerInteractor controllerInteractor)
        {
            TriggerHaptic(controllerInteractor.xrController);
        }
    }
    public void TriggerHaptic(XRBaseController controller)
    {
        if (intensity > 0)
        {
            controller.SendHapticImpulse(intensity, duration);
        }
    }
}

public class HapticInteractable : MonoBehaviour
{
    [SerializeField] Haptic hapticOnActivated;
    [SerializeField] Haptic hapticHoveredEntered;
    [SerializeField] Haptic hapticHoverExited;
    [SerializeField] Haptic hapticSelectEntered;
    [SerializeField] Haptic hapticSelectExited;

    void Start()
    {
        XRBaseInteractable interactable = this.GetComponent<XRBaseInteractable>();
        interactable.activated.AddListener(hapticOnActivated.TriggerHaptic);
        interactable.hoverEntered.AddListener(hapticHoveredEntered.TriggerHaptic);
        interactable.hoverExited.AddListener(hapticHoverExited.TriggerHaptic);
        interactable.selectEntered.AddListener(hapticSelectEntered.TriggerHaptic);
        interactable.selectExited.AddListener(hapticSelectExited.TriggerHaptic);
    }



}
