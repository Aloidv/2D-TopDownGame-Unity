using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    [SerializeField]
    [Range(1.0f, 10.0f)]
    int BulletSize = 1;

    [SerializeField]
    [Range(5.0f, 20.0f)]
    int BulletVelocity = 10;
    
    void Start()
    {
        transform.localScale *= BulletSize;
    }

    public int GetBulletVelocity()
    {
        return BulletVelocity;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Destroy(this);
    }
}
