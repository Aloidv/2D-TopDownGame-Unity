using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Weapon List", menuName = "ScriptableObject/Weapon List")]
public class WeaponList : ScriptableObject
{
    public List<Weapon> List;

    public Weapon findByName(string name)
    {
        foreach (Weapon weapon in List)
        {
            if (weapon.name == name)
            {
                return weapon;
            }
        }
        return null;
    }
}
