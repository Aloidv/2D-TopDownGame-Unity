using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Melee Weapon", menuName = "ScriptableObject/Melee Weapon")]
public class MeleeWeaponSO : WeaponSO
{
    public override void Attack(Transform transform)
    {
        throw new System.NotImplementedException();
    }
}
