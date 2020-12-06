using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotation_wall : MonoBehaviour
{
    void Start()
    {
        Input.gyro.enabled = true;
    }

    void Update()
    {
        var rot = Input.gyro.attitude;
        var rot2 = new Quaternion(-rot.x,-rot.z,-rot.y,rot.w);
        transform.rotation = rot2;
    }
}