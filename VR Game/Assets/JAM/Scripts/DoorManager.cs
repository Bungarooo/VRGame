using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class DoorManager : MonoBehaviour
{
    [Header("Time")]
    [SerializeField] [Range(.1f,3f)] float transitionTime;
    float timer;

    [Header("Positions")]
    [SerializeField] float openedPos;
    [SerializeField] float closedPos;

    [Header("Components")]
    [SerializeField] Transform leftDoor;
    [SerializeField] Transform rightDoor;

    void Start()
    {
        
    }

    void Update()
    {
        if(leftDoor.position.x == openedPos)
        {
            StartCoroutine(CloseDoor());
        }
        if(leftDoor.position.x == closedPos)
        {
            StartCoroutine(OpenDoor());
        }
    }

    IEnumerator CloseDoor()
    {
        timer = 0f;
        while (timer<transitionTime)
        {
            float currPos = Mathf.Lerp(openedPos, closedPos, timer/transitionTime);
            leftDoor.position = new Vector3 (currPos, leftDoor.position.y, leftDoor.position.z);
            rightDoor.position = new Vector3(-currPos, rightDoor.position.y, rightDoor.position.z);
            timer += Time.deltaTime;
            yield return null;
        }
        leftDoor.position = new Vector3(closedPos, leftDoor.position.y, leftDoor.position.z);
        rightDoor.position = new Vector3(-closedPos, leftDoor.position.y, leftDoor.position.z);
    }

    IEnumerator OpenDoor()
    {
        timer = 0f;
        while (timer < transitionTime)
        {
            float currPos = Mathf.Lerp(closedPos, openedPos, timer / transitionTime);
            leftDoor.position = new Vector3(currPos, leftDoor.position.y, leftDoor.position.z);
            rightDoor.position = new Vector3(-currPos, rightDoor.position.y, rightDoor.position.z);
            timer += Time.deltaTime;
            yield return null;
        }
        leftDoor.position = new Vector3(openedPos, leftDoor.position.y, leftDoor.position.z);
        rightDoor.position = new Vector3(-openedPos, leftDoor.position.y, leftDoor.position.z);
    }
}
