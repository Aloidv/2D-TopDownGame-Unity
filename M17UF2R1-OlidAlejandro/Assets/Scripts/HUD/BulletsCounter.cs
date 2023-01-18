using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class BulletsCounter : MonoBehaviour
{
    WeaponHolder weaponHolder;
    TMP_Text TMP;
    Image image;

    void Start()
    {
        weaponHolder = GameObject.FindGameObjectWithTag("WeaponHolder").GetComponent<WeaponHolder>();
        TMP = GetComponentInChildren<TMP_Text>();
        image = GetComponent<Image>();
    }

    void Update()
    {
        image.sprite = weaponHolder.GetSelectedWeapon().GetSprite();
        var iWantUseDWnotWeapon = (DistanceWeapon) weaponHolder.GetSelectedWeapon();
        TMP.text = iWantUseDWnotWeapon.GetTotalNumBullets().ToString() + " / " + iWantUseDWnotWeapon.GetCurrentNumBullets().ToString();
    }
}
