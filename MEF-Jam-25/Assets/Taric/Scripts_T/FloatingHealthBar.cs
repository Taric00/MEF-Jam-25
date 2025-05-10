using UnityEngine;
using UnityEngine.UI;

public class FloatingHealthBar : MonoBehaviour
{
    [SerializeField] private Slider slider;

    public void UpdateHealthbar(float health, float maxHealth)
    {
        slider.value = health / maxHealth;
    }
}