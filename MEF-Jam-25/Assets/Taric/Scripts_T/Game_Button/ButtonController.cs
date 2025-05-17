using UnityEngine;

public class ButtonController : MonoBehaviour
{
    private SpriteRenderer spriteRenderer;

    [Header("Tu� Spriteleri")]
    [SerializeField] private Sprite defaultImage;
    [SerializeField] private Sprite pressedImage;

    [Header("Tu� Ayarlar�")]
    public KeyCode keyToPress;

    private void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    private void Update()
    {
        if (Input.GetKeyDown(keyToPress))
        {
            spriteRenderer.sprite = pressedImage;

            // Ses �al
            //AudioManager.instance.PlayRandomButtonSound();
        }

        if (Input.GetKeyUp(keyToPress))
        {
            spriteRenderer.sprite = defaultImage;
        }
    }
}
