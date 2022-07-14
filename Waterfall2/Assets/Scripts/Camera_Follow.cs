using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera_Follow : MonoBehaviour { 

    public Transform myaim;

void Update ()
    {
        this.transform.position = new Vector3(0f, myaim.transform.position.y + 8f, myaim.transform.position.z + 35.47f - 14.54f);

    }
}