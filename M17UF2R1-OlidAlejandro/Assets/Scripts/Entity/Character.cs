using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour
{
    [SerializeField]
    [Range(5.0f, 20.0f)]
    internal int Velocity = 5;

    internal Rigidbody2D rigidbody2D;

    void Start()
    {
        
    }

    void Update()
    {
        
    }
}
