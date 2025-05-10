using UnityEngine;

public class CreditsScroll : MonoBehaviour
{
    public float scrollSpeed = 20f;
    public float startPosY = -500f;
    public float endPosY = 500f;

    private RectTransform rectTransform;

    private void Start()
    {
        rectTransform = GetComponent<RectTransform>();
        Vector2 startPosition = rectTransform.anchoredPosition;
        startPosition.y = startPosY;
        rectTransform.anchoredPosition = startPosition;
    }

    private void Update()
    {
        Vector2 position = rectTransform.anchoredPosition;
        position.y += scrollSpeed * Time.deltaTime;

        if (position.y >= endPosY)
        {
            position.y = startPosY;
        }

        rectTransform.anchoredPosition = position;
    }
}
