using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Weapon : MonoBehaviour
{
    [SerializeField]
    internal int AttackVelocity = 10;
    internal int AttackCooldown = 10;
    internal int Size = 1;

    void Start()
    {
        
    }

    void Update()
    {

    }

    internal abstract void Attack();
}
