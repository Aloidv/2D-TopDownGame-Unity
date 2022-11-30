using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public int BulletSize = 1;
    public int BulletVelocity = 1000;
    
    void Start()
    {
        GetComponent<Rigidbody2D>().velocity = gameObject.transform.position*BulletVelocity;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
