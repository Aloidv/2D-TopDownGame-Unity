using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LootPrefab : MonoBehaviour
{
    public Loot Loot;

    [SerializeField]
    WeaponList AvaiableWeapons;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            Player player = collision.GetComponent<Player>();

            switch (Loot.GetName())
            {
                case "Health":
                    player.Healing();
                    break;
                case "Coin":
                    player.TakeCoin();
                    break;
                case "Nails":
                    player.TakeWeapon(AvaiableWeapons.List[0]);
                    AvaiableWeapons.List.Remove(AvaiableWeapons.List[0]);
                    break;
                case "Water":
                    player.TakeWeapon(AvaiableWeapons.List[1]);
                    AvaiableWeapons.List.Remove(AvaiableWeapons.List[1]);
                    break;
                case "Lantern":
                    player.TakeWeapon(AvaiableWeapons.List[2]);
                    AvaiableWeapons.List.Remove(AvaiableWeapons.List[2]);
                    break;
                case "Wrench":
                    player.TakeWeapon(AvaiableWeapons.List[3]);
                    AvaiableWeapons.List.Remove(AvaiableWeapons.List[3]);
                    break;
                case "Tape":
                    player.TakeWeapon(AvaiableWeapons.List[4]);
                    AvaiableWeapons.List.Remove(AvaiableWeapons.List[4]);
                    break;
            }
        }

        Destroy(gameObject);
    }
}
