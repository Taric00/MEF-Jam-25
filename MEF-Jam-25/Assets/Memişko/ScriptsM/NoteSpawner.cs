using UnityEngine;

public class NoteSpawner : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
   
    
        public GameObject notePrefab;
        public Transform leftSpawnPoint, rightSpawnPoint;

        public void SpawnNote()
        {
            var side = SideManager.Instance.currentSide;
            var spawnPoint = side == Side.Left ? leftSpawnPoint : rightSpawnPoint;
            Instantiate(notePrefab, spawnPoint.position, Quaternion.identity, transform);
        }
    }

