using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Weapon List", menuName = "ScriptableObject/Weapon List")]
public class WeaponList : ScriptableObject
{
    [SerializeField]
    List<Weapon> Weapons;
}
