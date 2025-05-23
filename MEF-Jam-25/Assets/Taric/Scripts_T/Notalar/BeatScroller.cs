using UnityEngine;

public class BeatScroller : MonoBehaviour
{

    public float beatTempo;
    public bool hasStarted;

    void Start()
    {
        beatTempo = beatTempo / 15f;
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
    
}
