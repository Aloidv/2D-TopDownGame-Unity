using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponHolder : MonoBehaviour
{

    [SerializeField]
    int IndexSelectedWeapon = 0;

    [SerializeField]
    Weapon SelectedWeapon;

    [SerializeField]
    List<Weapon> Weapons;

    SpriteRenderer spriteRenderer;

    private void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        SelectedWeapon = Weapons[0];
    }

    void Update()
    {
        int previousSelectedWeapon = IndexSelectedWeapon;


        if (Input.GetAxis("Mouse ScrollWheel") > 0)
        {
            if (IndexSelectedWeapon >= Weapons.Count - 1)
            {
                IndexSelectedWeapon = 0;
            }
            else
            {
                IndexSelectedWeapon++;
            }
        }

        if (previousSelectedWeapon != IndexSelectedWeapon)
        {
            SelectWeapon();
            ChangeWeapon();
        }
    }

    private void ChangeWeapon()
    {
        spriteRenderer.sprite = SelectedWeapon.GetSprite();
    }

    private void SelectWeapon()
    {
        foreach (Weapon weapon in Weapons)
        {
            if (IndexSelectedWeapon == Weapons.IndexOf(weapon))
            {
                SelectedWeapon = Weapons[IndexSelectedWeapon];
            }
        }
    }

    public Weapon GetSelectedWeapon()
    {
        return SelectedWeapon;
    }
}
