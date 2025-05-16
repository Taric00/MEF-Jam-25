using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class GameManagerT : MonoBehaviour
{
    public static GameManagerT instance;
    public ShockWaveManager shockWaveManager;
    //public GameObject gameOverPanel;

    [Header("Score")]
    public int currentScore;
    public int scorePerNote = 100;
    public int scorePerGoodNote = 125;
    public int scorePerPerfectNote = 175;
    [SerializeField] Text scoreText;
    [SerializeField] private TurnCombatUI combatUI;


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
        //---Shader---//
        if (shockWaveManager != null)
        {
            shockWaveManager.CallShockWave();
        }
        AudioManager.instance.PlayRandomButtonSound();
        scoreText.text = "score: " + currentScore;
    }

    public void NormalHit()
    {
        currentScore += scorePerNote;
        //DealDamage(1);
        NoteHit();
        Debug.Log("Normal Hit -1");
        AudioManager.instance.PlayRandomButtonSound();
        combatUI.DealDamage(1);  // sýra kimdeyse rakibin caný azalýr

    }

    public void GoodHit()
    {
        currentScore += scorePerGoodNote;
/*        DealDamage(2)*/;
        NoteHit();
        Debug.Log("Good Hit -2");
        AudioManager.instance.PlayRandomButtonSound();
        combatUI.DealDamage(2);

    }

    public void PerfectHit()
    {
        currentScore += scorePerPerfectNote;
        //DealDamage(5);
        NoteHit();
        Debug.Log("Perfect Hit -5");
        AudioManager.instance.PlayRandomButtonSound();
        combatUI.DealDamage(5);

    }

    public void NoteMissed()
    {
        Debug.Log("Miss");
    }

    //public void DealDamage(float damageAmount)
    //{
    //    currentHealth -= damageAmount;
    //    currentHealth = Mathf.Clamp(currentHealth, 0, maxHealth);
    //    healthBar.UpdateHealthbar(currentHealth, maxHealth);

    //    //if (currentHealth <= 0)
    //    //{
    //    //    Debug.Log("Karakter öldü!");
    //    //    gameOverPanel.SetActive(!gameOverPanel.activeSelf);
    //    //}
    //}
}