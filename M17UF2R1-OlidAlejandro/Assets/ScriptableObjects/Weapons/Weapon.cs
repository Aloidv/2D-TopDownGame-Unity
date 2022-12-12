using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Weapon", menuName = "ScriptableObject/Weapon")]
public class Weapon : ScriptableObject
{
    InputMaster InputMaster;

    [Header("Weapon Settings")]

    [SerializeField]
    Sprite Sprite;

    //[SerializeField]
    //int Size = 1;

    //[SerializeField]
    //[Range(1, 10)]
    //int AttackVelocity = 10;

    [SerializeField]
    [Range(1, 10)]
    float AttackCooldown = 1;

    public virtual void Attack(Transform transform) { }

    public Sprite GetSprite() 
    {
        return Sprite;
    }

    public float GetAttackCoolDown()
    {
        return AttackCooldown*10;
    }
}