using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpForce : MonoBehaviour
{

    void Update()
    {
        this.GetComponent<Rigidbody>().AddForce(new Vector3(0,1,0));
    }
}
