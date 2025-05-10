using UnityEngine;

public class NoteObject : MonoBehaviour
{
    public bool canBePressed;
    public KeyCode keyToPress;
    [SerializeField] private GameObject hitEffect;

    [Header("Debug")]
    private bool hasBeenHit = false;


    void Start()
    {
        
    }

    void Update()
    {
        if (Input.GetKeyDown(keyToPress))
        {
            if (canBePressed && !hasBeenHit)
            {
                hasBeenHit = true;
                gameObject.SetActive(false);
                float yPos = Mathf.Abs(transform.position.y);


                //---Uzaklýk Hesabýna Göre Puan Daðýtma---//
                if (yPos > 0.7f)
                {
                    Debug.Log("normal Hit!");
                    GameManagerT.instance.NormalHit();
                    Instantiate(hitEffect, transform.position, hitEffect.transform.rotation);
                }

                else if (yPos > 0.3f)
                {
                    Debug.Log("good Hit!");
                    GameManagerT.instance.GoodHit();
                    Instantiate(hitEffect, transform.position, hitEffect.transform.rotation);

                }

                else
                {
                    Debug.Log("perfect Hit!");
                    GameManagerT.instance.PerfectHit();
                    Instantiate(hitEffect, transform.position, hitEffect.transform.rotation);
                }
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag == "Activator")
        {
            canBePressed = true;
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.tag == "Activator" && !hasBeenHit)
        {
            canBePressed = false;
            GameManagerT.instance.NoteMissed();
        }
    }
}
