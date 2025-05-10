using UnityEngine;
using System.Collections;

public class NoteSpawnerT : MonoBehaviour
{
    [Header("Her yön için spawn yönü")]
    public Transform upSpawnPoint;
    public Transform downSpawnPoint;
    public Transform leftSpawnPoint;
    public Transform rightSpawnPoint;

    [Header("Note Prefabs")]
    public GameObject[] notePrefabs;

    [Header("Spawn Ayarlarý")]
    public int totalNotesToSpawn = 10;
    public float spawnDelay = 1f;


    public IEnumerator SpawnNotesRoutine(int totalNotesToSpawn, float spawnDelay, System.Action onComplete)
    {
        for (int i = 0; i < totalNotesToSpawn; i++)
        {
            SpawnRandomNote();
            yield return new WaitForSeconds(spawnDelay);
        }

        Debug.Log("Tüm notalar spawn edildi.");
        onComplete?.Invoke();
    }

    public void StartSpawning(int totalNotes, float delay, System.Action onComplete)
    {
        StartCoroutine(SpawnNotesRoutine(totalNotes, delay, onComplete));
    }

    public void SpawnRandomNote()
    {
        int index = Random.Range(0, notePrefabs.Length);
        SpawnNote(notePrefabs[index]);
    }

    public void SpawnNote(GameObject notePrefab)
    {
        Note note = notePrefab.GetComponent<Note>();
        Transform spawnPoint = GetSpawnPointByDirection(note.direction);

        if (spawnPoint != null)
        {
            Instantiate(notePrefab, spawnPoint.position, notePrefab.transform.rotation);
        }
        else
        {
            Debug.LogWarning("No spawn point assigned for direction: " + note.direction);
        }
    }

    private Transform GetSpawnPointByDirection(NoteDirection direction)
    {
        switch (direction)
        {
            case NoteDirection.Up:
                return upSpawnPoint;
            case NoteDirection.Down:
                return downSpawnPoint;
            case NoteDirection.Left:
                return leftSpawnPoint;
            case NoteDirection.Right:
                return rightSpawnPoint;
            default:
                return null;
        }
    }
}