using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemStore : MonoBehaviour
{
    [SerializeField]
    Loot Item;
    
    [SerializeField]
    PlayerController PlayerController;
    
    [SerializeField]
    PlayerSO playerSO;
    
    [SerializeField]
    WeaponList AvaiableWeapons;

    public void BuyItem()
    {
        playerSO.Coins -= Item.GetPrice();

        switch (Item.GetName())
        {
            case "Health":
                PlayerController.Healing();
                break;
            default:
                PlayerController.TakeWeapon(AvaiableWeapons.findByName(Item.GetName()));
                break;
        }
    }

}
