using UnityEngine;

public class ButtonController : MonoBehaviour
{
    private SpriteRenderer SpriteRenderer;
    [SerializeField] private Sprite defaultImage, pressedImage;
    public KeyCode KeyToPress;
    void Start()
    {
        SpriteRenderer = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyToPress))
        {
            SpriteRenderer.sprite = pressedImage;
        }

        if(Input.GetKeyUp(KeyToPress))
        {
            SpriteRenderer.sprite = defaultImage;
        }
    }
}
