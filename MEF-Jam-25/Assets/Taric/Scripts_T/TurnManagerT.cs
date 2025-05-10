using UnityEngine;

public class TurnManager : MonoBehaviour
{
    public NoteSpawnerT noteSpawner;
    public int notesPerTurn = 10;
    public float spawnDelay = 1f;

    private bool isSpawning = false;

    public void OnTurnButtonPressed()
    {
        if (!isSpawning)
        {
            Debug.Log("Sýra deðiþti!");
            isSpawning = true;
            noteSpawner.StartSpawning(notesPerTurn, spawnDelay, () =>
            {
                isSpawning = false;
                Debug.Log("Sýra tamamlandý. Þimdi butona tekrar basýlabilir.");
            });
        }
    }
}

