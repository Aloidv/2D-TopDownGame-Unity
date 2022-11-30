using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    void Update()
    {
        Vector3 newPos = GameObject.FindGameObjectWithTag("Player").transform.position;
        newPos.z = -10;
        gameObject.transform.position = newPos;
    }
}
