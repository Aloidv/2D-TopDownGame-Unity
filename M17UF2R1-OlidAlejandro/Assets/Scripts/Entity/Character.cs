using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Character : MonoBehaviour
{
    [SerializeField]
    internal int velocity;

    void Start()
    {
        
    }

    void Update()
    {
        
    }

    internal abstract void InputAttack();
}
