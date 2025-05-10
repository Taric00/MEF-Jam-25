using UnityEngine;
using static UnityEngine.RuleTile.TilingRuleOutput;

public class NotaHareket : MonoBehaviour
{
    public float speed = 200f;
    void Update() => transform.Translate(Vector3.down * speed * Time.deltaTime);
}

