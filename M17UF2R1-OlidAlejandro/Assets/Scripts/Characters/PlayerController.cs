using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    InputMaster InputMaster;
    Vector3 Movement;
    HealthBar healthBar;
    Animator animator;
    float counterCadency = 0;
    float counterDash = 0;

    public PlayerSO playerSO;
    public WeaponHolder WeaponHolder;
    public Weapon SelectedWeapon;

    void Start()
    {
        animator = GetComponent<Animator>();
        SelectedWeapon = WeaponHolder.GetSelectedWeapon();
        healthBar = FindObjectOfType<HealthBar>();
        InputMaster = new InputMaster();
        InputMaster.Gameplay.Enable();
        GameManager.Instance.ResetPlayerStats();
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
        animator.SetBool("IsDashing", playerSO.isDashing);
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
        if (!playerSO.isDashing)
        {
            Movement = InputMaster.Gameplay.Movement.ReadValue<Vector2>();
        }

        transform.position = transform.position + Movement * Time.deltaTime * playerSO.Velocity;
        GetComponent<Rigidbody2D>().velocity = Movement * playerSO.Velocity;
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
        if (playerSO.isDashing == false)
        {
            if (counterDash <= playerSO.DashCooldown)
            {
                counterDash += Time.deltaTime;

            }

            if (InputMaster.Gameplay.Dash.WasPressedThisFrame() && counterDash >= playerSO.DashCooldown)
            {
                Dash();
                counterDash = 0;
            }
        }

        if (playerSO.isDashing == true)
        {
            if (counterDash <= playerSO.DashDuration)
            {
                counterDash += Time.deltaTime;
            }
            else 
            {
                counterDash = 0;
                playerSO.isDashing = false;
                playerSO.Velocity = playerSO.DefaultVelocity;
            }
        }
    }

    void Dash()
    {
        playerSO.isDashing = true;
        playerSO.Velocity = playerSO.DashVelocity;
    }

    public void Healing()
    {
        playerSO.CurrentHealth += 20;
        if (playerSO.CurrentHealth > 100)
        {
            playerSO.CurrentHealth = 100;
        }
    }

    public void TakeCoin()
    {
        playerSO.Coins++;
        if (playerSO.Coins > 20)
        {
            Debug.Log("Has ganado");
        }
    }

    public void EnemyDefeated()
    {
        playerSO.EnemiesDefeated++;
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

    public void TakeDamage(float damage)
    {
        playerSO.CurrentHealth -= damage;
        healthBar.SetHealth((int)playerSO.CurrentHealth);
        GameManager.Instance.CheckDefeat();
    }

    private void InputSeller(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Seller") && InputMaster.Gameplay.Attack.IsPressed())
        {
            collision.GetComponent<CanvasRenderer>().gameObject.SetActive(true);
        }
    }

    private void OnCollisionStay2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            TakeDamage(collision.gameObject.GetComponent<EnemyController>().EnemySO.EnemyDamage * Time.deltaTime);
        }

    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        InputSeller(collision);
    }
}
