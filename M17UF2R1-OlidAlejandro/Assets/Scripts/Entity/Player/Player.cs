using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : Character
{
    [SerializeField]
    List<Weapon> Weapons;
    WeaponHolder weaponHolder;

    [SerializeField]
    bool isDashing;

    [SerializeField]
    int Weight;


    Rigidbody2D rb;
    SpriteRenderer spriteRenderer;
    Vector2 translationFinal;


    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        spriteRenderer = GetComponent<SpriteRenderer>();
        weaponHolder = gameObject.GetComponentInChildren<WeaponHolder>();
    }

    void Update()
    {
        InputDash();
        InputMovement();
        InputDirection();
        InputAttack();

    }

    void FixedUpdate()
    {
        //Movement
        rb.MovePosition(rb.position + translationFinal);
        Dash();
    }



    void InputDash()
    {
        if (Input.GetKeyDown(KeyCode.LeftShift))
        {
            isDashing = true;
        }
    }


    void Dash()
    {
        new WaitForSeconds(5);
        isDashing = false;
    }

    //Se puede hacer desde el animator con 8 direcciones esperar a alvaro?

    void InputDirection()
    {
        Vector2 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        Vector2 direction = mousePosition - rb.position;
        float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg - 90f;
        rb.rotation = angle;
    }

    void InputMovement()
    {
        float translationVertical = Input.GetAxis("Vertical");
        float translationHorizontal = Input.GetAxis("Horizontal");
        translationFinal = new Vector2(translationHorizontal, translationVertical).normalized  * Time.deltaTime * velocity * 100 / Weight;
    }

    internal override void InputAttack()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            // Cada tipo de arma tiene un override de Attack()
            // indicando el arma seleccionada llamo a su metodo
            Weapons[weaponHolder.SelectedWeapon].Attack();
        }
    }
}
