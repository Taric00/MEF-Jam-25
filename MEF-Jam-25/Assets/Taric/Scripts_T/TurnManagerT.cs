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
            Debug.Log("S�ra de�i�ti!");
            isSpawning = true;
            noteSpawner.StartSpawning(notesPerTurn, spawnDelay, () =>
            {
                isSpawning = false;
                Debug.Log("S�ra tamamland�. �imdi butona tekrar bas�labilir.");
            });
        }
    }
}

