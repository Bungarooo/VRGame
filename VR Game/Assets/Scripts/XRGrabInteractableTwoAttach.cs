using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

/// <summary>
/// Useful if want attachable to anchor to a precise position in the player's hand
/// (not the relative position the item happened to be picked up at)
/// </summary>
public class XRGrabInteractableTwoAttach : XRGrabInteractable
{
    [SerializeField] Transform leftAttachTransform;
    [SerializeField] Transform rightAttachTransform;

    protected override void OnSelectEntered(SelectEnterEventArgs args)
    {
        if(args.interactorObject.transform.CompareTag("Left Hand"))
        {
            attachTransform = leftAttachTransform;
        }
        else if (args.interactorObject.transform.CompareTag("Right Hand"))
        {
            attachTransform = rightAttachTransform;
        }

        base.OnSelectEntered(args);
    }

}
