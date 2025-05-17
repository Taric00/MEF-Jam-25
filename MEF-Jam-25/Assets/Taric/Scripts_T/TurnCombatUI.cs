using UnityEngine;
using UnityEngine.UI;

public class TurnCombatUI : MonoBehaviour
{
    public Slider player1Bar;
    public Slider player2Bar;
    public CanvasGroup player1Group;
    public CanvasGroup player2Group;

    public int maxHealth = 100;
    private int player1Health;
    private int player2Health;
    public bool isPlayer1Turn = true;


    void Start()
    {
        player1Health = maxHealth;
        player2Health = maxHealth;

        player1Bar.maxValue = maxHealth;
        player2Bar.maxValue = maxHealth;

        player1Bar.value = player1Health;
        player2Bar.value = player2Health;

        UpdateBarStates();
    }

    public void DealDamage(int amount)
    {
        if (isPlayer1Turn)
        {
            player2Health -= amount;
            player2Health = Mathf.Clamp(player2Health, 0, maxHealth);
        }
        else
        {
            player1Health -= amount;
            player1Health = Mathf.Clamp(player1Health, 0, maxHealth);
        }
    }

    public void SwitchTurn()
    {
        isPlayer1Turn = !isPlayer1Turn;
        UpdateBarStates();
    }


    //---Healt Barlarý Transparan yapmak için---//
    void UpdateBarStates()
    {
        player2Group.alpha = isPlayer1Turn ? 1f : 1f;
        player1Group.alpha = isPlayer1Turn ? 1f : 1f;
    }
}
