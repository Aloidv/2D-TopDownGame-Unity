using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : Character
{
    public WeaponHolder WeaponHolder;

    void Start()
    {
        rigidbody2D = GetComponent<Rigidbody2D>();
        WeaponHolder = GetComponentInChildren<WeaponHolder>();
    }

    void Update()
    {
        InputDirection();
        InputMovement();
        WeaponHolder.GetSelectedWeapon().Attack(WeaponHolder.transform);
    }

    Vector3 InputDirection()
    {
        Vector3 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        Vector2 direction = mousePosition - transform.position;
        float angle = Vector2.SignedAngle(Vector2.right, direction);
        return transform.eulerAngles = new Vector3(0, 0, angle);
    }

    void InputMovement()
    {
        float horizontal = Input.GetAxisRaw("Horizontal");
        float vertical = Input.GetAxisRaw("Vertical");
        transform.position = transform.position + new Vector3(horizontal, vertical).normalized * Time.deltaTime * Velocity;
    }
}
