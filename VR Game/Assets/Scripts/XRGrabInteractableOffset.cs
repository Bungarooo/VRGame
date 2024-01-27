using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

/// <summary>
/// Useful if want attachable to anchor to a precise position in the player's hand
/// (not the relative position the item happened to be picked up at)
/// </summary>
public class XRGrabInteractableOffset : XRGrabInteractable
{
    void Start()
    {
        if (!attachTransform)
        {
            GameObject attachPoint = new GameObject("Offset Grab Pivot");
            attachPoint.transform.SetParent(transform, false);
            attachTransform = attachPoint.transform;
        }
    }

    protected override void OnSelectEntered(SelectEnterEventArgs args)
    {
        attachTransform.position = args.interactableObject.transform.position;
        attachTransform.rotation = args.interactableObject.transform.rotation;
        base.OnSelectEntered(args);
    }

}
