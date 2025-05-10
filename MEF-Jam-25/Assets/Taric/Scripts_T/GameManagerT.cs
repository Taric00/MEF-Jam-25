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
    }

    public void GoodHit()
    {
        currentScore += scorePerGoodNote;
        NoteHit();
    }

    public void PerfectHit()
    {
        currentScore += scorePerPerfectNote;
        NoteHit();
    }

    public void NoteMissed()
    {   
        Debug.Log("Miss");
    }

    //aþaðýyý ekledim
    //void Awake()
    //{
    //    BeatScroller.globalTempo = 2f; // örneðin 2 birim/saniye hýzý
    //}
}
