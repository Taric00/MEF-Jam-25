using UnityEngine;

public class EffectObject : MonoBehaviour
{
    public float lifeTime = 1f;

    void Start()
    {
        
    }

    void Update()
    {
        Destroy(gameObject, lifeTime);
    }
}
