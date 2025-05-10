using UnityEngine;

using System.Collections;

public class NoteSpawnerAuto : MonoBehaviour
{
    public GameObject[] notePrefabs; // 4 nota prefabý
    public Transform spawnPosition;  // Hepsi ayný pozisyondan düþecek (NoteHolder üstü)

    public float spawnInterval = 0.5f;

    void Start()
    {
        StartCoroutine(SpawnLoop());
    }

    IEnumerator SpawnLoop()
    {
        while (true)
        {
            int i = Random.Range(0, notePrefabs.Length);
            Instantiate(notePrefabs[i], spawnPosition.position, Quaternion.identity);
            yield return new WaitForSeconds(spawnInterval);
        }
    }
}

