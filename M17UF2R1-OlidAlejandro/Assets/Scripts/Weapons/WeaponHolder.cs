using UnityEngine;

public class WeaponHolder : MonoBehaviour
{

    [SerializeField]
    int IndexSelectedWeapon = 0;

    [SerializeField]
    WeaponSO SelectedWeapon;

    [SerializeField]
    WeaponListSO Weapons;

    SpriteRenderer spriteRenderer;

    private void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        SelectedWeapon = Weapons.List[0];
        ChangeWeapon();
    }

    void Update()
    {
        int previousSelectedWeapon = IndexSelectedWeapon;


        if (Input.GetAxis("Mouse ScrollWheel") > 0)
        {
            if (IndexSelectedWeapon >= Weapons.List.Count - 1)
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
        foreach (WeaponSO weapon in Weapons.List)
        {
            if (IndexSelectedWeapon == Weapons.List.IndexOf(weapon))
            {
                SelectedWeapon = Weapons.List[IndexSelectedWeapon];
            }
        }
    }

    public WeaponSO GetSelectedWeapon()
    {
        return SelectedWeapon;
    }

    public WeaponListSO GetWeapons()
    {
        return Weapons;
    }
}
