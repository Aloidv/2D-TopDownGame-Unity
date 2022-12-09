using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Weapon", menuName = "ScriptableObject/Weapon")]
public class Weapon : ScriptableObject
{
    [Header("Weapon Settings")]

    [SerializeField]
    Sprite Sprite;

    [SerializeField]
    int Size = 1;

    [SerializeField]
    [Range(1.0f, 10.0f)]
    int AttackVelocity = 10;

    [SerializeField]
    [Range(1.0f, 10.0f)]
    int AttackCooldown = 10;

    public virtual void Attack(Transform transform) { }

    public Sprite GetSprite() 
    {
        return Sprite;
    }
}
