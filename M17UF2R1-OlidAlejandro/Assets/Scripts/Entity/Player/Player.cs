using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : Character
{
    public List<Weapon> Weapons;


    void Start()
    {
        rigidbody2D = GetComponent<Rigidbody2D>();

    }

    void Update()
    {



        if ( Input.GetMouseButtonDown(0) )
        {
            Shoot();
        }


        InputDirection();
        InputMovement();
    }



    private void Shoot()
    {
    }

    private void InputDirection()
    {
        Vector3 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        Vector2 direction = mousePosition - transform.position;
        float angle = Vector2.SignedAngle(Vector2.right, direction);
        transform.eulerAngles = new Vector3(0, 0, angle);
    }

    void InputMovement()
    {
       /* if (Input.GetKeyDown(KeyCode.A))
        {
            rigidbody2D.AddForce(Vector2.left * velocity, ForceMode2D.Impulse);
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            rigidbody2D.AddForce(Vector2.right * velocity, ForceMode2D.Impulse);
        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            rigidbody2D.AddForce(Vector2.down * velocity, ForceMode2D.Impulse);
        }
        if (Input.GetKeyDown(KeyCode.W))
        {
            rigidbody2D.AddForce(Vector2.up * velocity, ForceMode2D.Impulse);
        } */
    }
}
