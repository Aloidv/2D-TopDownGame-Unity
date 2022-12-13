using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
    [SerializeField]
    Gradient gradient;
    Slider slider;
    Player player;
    Image valueBar;

    void Start()
    {
        slider = GetComponent<Slider>();
        player = FindObjectOfType<Player>();
        valueBar = GetComponentInChildren<Image>();
        SetHealth(player.GetCurrentHealth());
        valueBar.color = gradient.Evaluate(1f);
    }

    void Update()
    {
    }

    public void SetHealth(int health)
    {
        slider.value = health;
        valueBar.color = gradient.Evaluate(slider.normalizedValue);
    }
}
