using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
    public PlayerSO PlayerSO;
    [SerializeField]
    Gradient gradient;
    Slider slider;
    Image valueBar;

    void Start()
    {
        slider = GetComponent<Slider>();
        valueBar = GetComponentInChildren<Image>();
        SetHealth((int)PlayerSO.CurrentHealth);
        valueBar.color = gradient.Evaluate(1f);
    }

    public void SetHealth(int health)
    {
        slider.value = health;
        valueBar.color = gradient.Evaluate(slider.normalizedValue);
    }
}
