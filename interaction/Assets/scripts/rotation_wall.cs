using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotation_wall : MonoBehaviour
{
    private Gyroscope m_gyro;

    private void Start()
    {
        Input.gyro.enabled = true;
    }

    void Update()
    {
        m_gyro = Input.gyro;
        transform.rotation = m_gyro.attitude;
    }
}