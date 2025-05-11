using UnityEngine;

public class ObjectTogglerT : MonoBehaviour
{
    public GameObject objToToggle1;
    public GameObject objToToggle2;
    public GameObject shockwaveObject;

    public Vector2 positionA = new Vector2(-3f, 0f);
    public Vector2 positionB = new Vector2(3f, 0f);

    private bool isToggled = false;
    private bool atPositionA = true;

    public void ToggleObjects()
    {
        isToggled = !isToggled;

        objToToggle1.SetActive(isToggled);
        objToToggle2.SetActive(!isToggled);


        if (shockwaveObject != null)
        {
            atPositionA = !atPositionA;
            shockwaveObject.transform.position = atPositionA ? (Vector3)positionA : (Vector3)positionB;
        }
    }
}
