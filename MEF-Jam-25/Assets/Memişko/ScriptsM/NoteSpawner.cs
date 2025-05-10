//using UnityEngine;

//public class NoteSpawner : MonoBehaviour
//{
//    // Start is called once before the first execution of Update after the MonoBehaviour is created


//        public GameObject notePrefab;
//        public Transform leftSpawnPoint, rightSpawnPoint;

//        public void SpawnNote()
//        {
//            var side = SideManager.Instance.currentSide;
//            var spawnPoint = side == Side.Left ? leftSpawnPoint : rightSpawnPoint;
//            Instantiate(notePrefab, spawnPoint.position, Quaternion.identity, transform);
//        }
//    }

using UnityEngine;
using System.Collections;

public class NoteSpawner : MonoBehaviour
{
    public GameObject[] notePrefabs; // 4 farklý nota prefabý
    public Transform[] lanes;        // 4 spawn pozisyonu (x ekseninde farklý)

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
            Instantiate(notePrefabs[i], lanes[i].position, Quaternion.identity);
            yield return new WaitForSeconds(spawnInterval);
        }
    }
}
