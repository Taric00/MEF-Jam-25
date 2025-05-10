using UnityEngine;
using UnityEngine.UI;

public class UIKONTROL : MonoBehaviour
{
    public Slider player1Bar;
    public Slider player2Bar;
    public CanvasGroup player1Group;
    public CanvasGroup player2Group;

    public int maxHealth = 100;
    private int player1Health;
    private int player2Health;
    private bool isPlayer1Turn = true;

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

    public void DealDamageAndSwitch()
    {
        if (isPlayer1Turn)
        {
            player2Health -= 10;
            if (player2Health < 0) player2Health = 0;
            player2Bar.value = player2Health;
        }
        else
        {
            player1Health -= 10;
            if (player1Health < 0) player1Health = 0;
            player1Bar.value = player1Health;
        }

        isPlayer1Turn = !isPlayer1Turn;
        UpdateBarStates();
    }

    void UpdateBarStates()
    {
        if (isPlayer1Turn)
        {
            player1Group.alpha = 1f;
            player2Group.alpha = 0.3f;
        }
        else
        {
            player1Group.alpha = 0.3f;
            player2Group.alpha = 1f;
        }
    }
}
