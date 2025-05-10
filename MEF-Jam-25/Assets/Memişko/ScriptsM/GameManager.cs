using UnityEngine;
using System.Collections;

// Start is called once before the first execution of Update after the MonoBehaviour is created
public class GameManager : MonoBehaviour
    {
        public NoteSpawner spawner;

        void Start()
        {
            StartCoroutine(Loop());
        }

        IEnumerator Loop()
        {
            while (true)
            {
                for (int i = 0; i < 10; i++)
                {
                    spawner.SpawnNote();
                    yield return new WaitForSeconds(0.5f);
                }

                SideManager.Instance.SwitchSide();
                yield return new WaitForSeconds(2f);
            }
        }
    }


