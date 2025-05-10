using UnityEngine;
using UnityEngine.UI;

public class GameManagerT : MonoBehaviour
{
    public static GameManagerT instance;

    [Header("Score")]
    public int currentScore;
    public int scorePerNote = 100;
    public int scorePerGoodNote = 125;
    public int scorePerPerfectNote = 175;
    [SerializeField] Text scoreText;


    void Start()
    {
        instance = this;
        scoreText.text = "score: 0";
    }

    void Update()
    {
        
    }

    public void NoteHit()
    {
        Debug.Log("Hit on Time");
        scoreText.text = "score: " + currentScore;
    }

    public void NormalHit()
    {
        currentScore += scorePerNote;
        NoteHit();
        Debug.Log("Normal Hit -10");
    }

    public void GoodHit()
    {
        currentScore += scorePerGoodNote;
        NoteHit();
        Debug.Log("Normal Hit -20");
    }

    public void PerfectHit()
    {
        currentScore += scorePerPerfectNote;
        NoteHit();
        Debug.Log("Normal Hit -50");
    }

    public void NoteMissed()
    {   
        Debug.Log("Miss");
    }
}
