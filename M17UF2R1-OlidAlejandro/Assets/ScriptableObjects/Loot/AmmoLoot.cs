using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Ammo Loot", menuName = "ScriptableObject/Ammo Loot")]
public class AmmoLoot : Loot
{
    [SerializeField]
    Bullet Bullet;

    [SerializeField]
    int Amount;
}
