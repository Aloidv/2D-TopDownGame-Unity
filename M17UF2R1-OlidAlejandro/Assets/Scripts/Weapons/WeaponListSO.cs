using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Weapon List", menuName = "ScriptableObject/Weapon List")]
public class WeaponListSO : ScriptableObject
{
    public List<WeaponSO> List;

    public WeaponSO findByName(string name)
    {
        foreach (WeaponSO weapon in List)
        {
            if (weapon.name == name)
            {
                return weapon;
            }
        }
        return null;
    }
}
