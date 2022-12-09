using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Player : Character
{
    [SerializeField]
    WeaponHolder WeaponHolder;

    [SerializeField]
    Weapon SelectedWeapon;

    InputMaster InputMaster;
    float counterCadency = 0;



    void Start()
    {
        rigidbody2D = GetComponent<Rigidbody2D>();
        WeaponHolder = GetComponentInChildren<WeaponHolder>();
        InputMaster = new InputMaster();
        InputMaster.Gameplay.Enable();

    }

    void Update()
    {
        InputDirection();
        InputMovement();
        Attack();
    }

    Vector3 InputDirection()
    {
        Vector3 mousePosition = Camera.main.ScreenToWorldPoint(InputMaster.Gameplay.Aim.ReadValue<Vector2>());
        Vector2 direction = mousePosition - transform.position;
        float angle = Vector2.SignedAngle(Vector2.right, direction);
        return transform.eulerAngles = new Vector3(0, 0, angle);
    }

    void InputMovement()
    {
        Vector3 movement = InputMaster.Gameplay.Movement.ReadValue<Vector2>();
        transform.position = transform.position + movement * Time.deltaTime * Velocity;
    }

    void Attack()
    {
        SelectedWeapon = WeaponHolder.GetSelectedWeapon();
        counterCadency += Time.deltaTime;
        Debug.Log(counterCadency);

        if (InputMaster.Gameplay.Attack.IsPressed() && counterCadency >= SelectedWeapon.GetAttackCoolDown())
        {
                SelectedWeapon.Attack(WeaponHolder.transform);
                counterCadency = 0;
        }
    }
}
