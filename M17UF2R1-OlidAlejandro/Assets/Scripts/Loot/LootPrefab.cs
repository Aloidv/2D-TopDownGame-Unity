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
            PlayerController player = collision.GetComponent<PlayerController>();

            switch (Loot.GetName())
            {
                case "Health":
                    player.Healing();
                    break;
                case "Coin":
                    player.TakeCoin();
                    break;
                default:
                    player.TakeWeapon(AvaiableWeapons.findByName(Loot.GetName()));
                    break;
            }
        }

        Destroy(gameObject);
    }
}
