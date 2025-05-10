using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;

    [Header("Score")]
    public int currentScore;
    public int scorePerNote = 100;
    public int scorePerGoodNote = 125;
    public int scorePerPerfectNote = 175;
    [SerializeField] Text scoreText;

    [Header("Health Settings")]
    public float maxHealth = 100f;
    public float currentHealth;
    [SerializeField] private FloatingHealthBar healthBar;
    void Start()
    {
        instance = this;
        scoreText.text = "score: 0";

        currentHealth = maxHealth;
        healthBar.UpdateHealthbar(currentHealth, maxHealth);
    }

    public void NoteHit()
    {
        Debug.Log("Hit on Time");
        scoreText.text = "score: " + currentScore;
    }

    public void NormalHit()
    {
        currentScore += scorePerNote;
        DealDamage(10);
        NoteHit();
        Debug.Log("Normal Hit -10");
    }

    public void GoodHit()
    {
        currentScore += scorePerGoodNote;
        DealDamage(20);
        NoteHit();
        Debug.Log("Good Hit -20");
    }

    public void PerfectHit()
    {
        currentScore += scorePerPerfectNote;
        DealDamage(50);
        NoteHit();
        Debug.Log("Perfect Hit -50");
    }

    public void NoteMissed()
    {
        Debug.Log("Miss");
    }

    public void DealDamage(float damageAmount)
    {
        currentHealth -= damageAmount;
        currentHealth = Mathf.Clamp(currentHealth, 0, maxHealth);
        healthBar.UpdateHealthbar(currentHealth, maxHealth);

        if (currentHealth <= 0)
        {
            Debug.Log("Karakter öldü!");
            // Burada oyun bitirme mantýðý vs. eklenebilir
        }
    }
}