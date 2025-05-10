using UnityEngine;

public class BeatScroller : MonoBehaviour
{

    public float beatTempo;
    public bool hasStarted;

    void Start()
    {
        beatTempo = beatTempo / 60f;
    }

    
    void Update()
    {
        if(!hasStarted)
        {
            if(Input.anyKeyDown)
            {
                hasStarted = true;
            }
        }
        else
        {
            transform.position -= new Vector3(0f, beatTempo * Time.deltaTime, 0f);
        }
    }
    
    
        //public float beatSpeed; // Do�rudan kullan�lacak tempo
        //public static float globalTempo; // GameManager'dan al�n�r
        //public bool hasStarted;

        //void Start()
        //{
        //    if (beatSpeed == 0) // E�er �zel ayar yoksa global tempo kullan
        //        beatSpeed = globalTempo;
        //}

        //void Update()
        //{
        //    if (!hasStarted) return;
        //    transform.position -= new Vector3(0f, beatSpeed * Time.deltaTime, 0f);
        //}
    
}
