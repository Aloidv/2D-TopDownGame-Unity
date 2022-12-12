using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour
{
    [SerializeField]
    [Range(5.0f, 20.0f)]
    internal float Velocity = 5;

    internal new Rigidbody2D rigidbody2D;
    internal new Collider2D collider2D;

    void Start()
    {
        
    }

    void Update()
    {
        
    }
}
