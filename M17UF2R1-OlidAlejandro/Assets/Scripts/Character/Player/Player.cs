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

    [SerializeField]
    float counterCadency = 0;

    [SerializeField]
    float counterDash = 0;

    [SerializeField]
    float DashCooldown = 3;

    [SerializeField]
    float DashDuration = 0.5f;

    InputMaster InputMaster;

    [SerializeField]
    private float DashVelocity = 10;

    [SerializeField]
    private float DefaultVelocity = 1;

    [SerializeField]
    private bool isDashing = false;

    [SerializeField]
    int CurrentHealth;

    [SerializeField]
    int MaxHealth = 100;


    [SerializeField]
    int Coins = 0;

    Vector3 Movement;
    HealthBar healthBar;
    Animator animator;


    void Start()
    {
        rigidbody2D = GetComponent<Rigidbody2D>();
        collider2D = GetComponent<Collider2D>();
        animator = GetComponent<Animator>();
        WeaponHolder = GetComponentInChildren<WeaponHolder>();
        SelectedWeapon = WeaponHolder.GetSelectedWeapon();
        healthBar = FindObjectOfType<HealthBar>();
        InputMaster = new InputMaster();
        InputMaster.Gameplay.Enable();
        CurrentHealth = MaxHealth;
    }

    void Update()
    {
        InputDirection();
        InputMovement();
        InputAttack();
        InputDash();
        UpdateAnimation();
    }

    void UpdateAnimation()
    {
        animator.SetFloat("Velocity", GetComponent<Rigidbody2D>().velocity.magnitude);
        animator.SetFloat("BlendY", Movement.y);
        animator.SetFloat("BlendX", Movement.x);
        animator.SetBool("IsDashing", isDashing);
    }

    Vector3 InputDirection()
    {
        Vector3 mousePosition = Camera.main.ScreenToWorldPoint(InputMaster.Gameplay.Aim.ReadValue<Vector2>());
        Vector2 direction = mousePosition - transform.position;
        float angle = Vector2.SignedAngle(Vector2.right, direction);
        return WeaponHolder.transform.eulerAngles = new Vector3(0, 0, angle);
    }

    void InputMovement()
    {
        if (!isDashing)
        {
            Movement = InputMaster.Gameplay.Movement.ReadValue<Vector2>();
        }

        transform.position = transform.position + Movement * Time.deltaTime * Velocity;
        GetComponent<Rigidbody2D>().velocity = Movement * Velocity;
    }

    void InputAttack()
    {
        if (counterCadency < SelectedWeapon.GetAttackCoolDown())
        {
            counterCadency += Time.deltaTime;
        }

        if (InputMaster.Gameplay.Attack.IsPressed() && counterCadency >= SelectedWeapon.GetAttackCoolDown())
        {
            SelectedWeapon = WeaponHolder.GetSelectedWeapon();
            SelectedWeapon.Attack(WeaponHolder.transform);
            counterCadency = 0;
        }
    }

    void InputDash()
    {
        if (isDashing == false)
        {
            if (counterDash <= DashCooldown)
            {
                counterDash += Time.deltaTime;

            }

            if (InputMaster.Gameplay.Dash.WasPressedThisFrame() && counterDash >= DashCooldown)
            {
                Dash();
                counterDash = 0;
            }
        }

        if (isDashing == true)
        {
            if (counterDash <= DashDuration)
            {
                counterDash += Time.deltaTime;
            }
            else 
            {
                counterDash = 0;
                isDashing = false;
                Velocity = DefaultVelocity;
            }
        }
    }

    void Dash()
    {
        isDashing = true;
        Velocity = DashVelocity;
    }

    public void TakeDamage(int damage)
    {
        CurrentHealth -= damage;
        healthBar.SetHealth(CurrentHealth);
    }

    public void Healing()
    {
        CurrentHealth += 20;
        if (CurrentHealth > 100)
        {
            CurrentHealth = 100;
        }
    }

    public void TakeCoin()
    {
        Coins++;
        if (Coins > 20)
        {
            Debug.Log("Has ganado");
        }
    }

    public void TakeWeapon(Weapon newWeapon)
    {
        bool found = false;
        foreach (Weapon weapon in WeaponHolder.GetWeapons().List)
        {
            if (newWeapon.name == weapon.name)
            {
                weapon.TakeBullets();
                found = true;
                Debug.Log("lo encontre");
            }
        }
        if (!found)
        {
            Debug.Log("lo recojo");
            WeaponHolder.GetWeapons().List.Add(newWeapon);
        }
    }

    public int GetCurrentHealth()
    {
        return CurrentHealth;
    }

    public int GetCoins()
    {
        return Coins;
    }
}
