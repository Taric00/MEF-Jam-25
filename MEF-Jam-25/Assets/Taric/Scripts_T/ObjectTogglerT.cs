using UnityEngine;

public class ObjectTogglerT : MonoBehaviour
{
    public GameObject objToToggle1;
    public GameObject objToToggle2; 

    private bool isToggled = false; 

    public void ToggleObjects()
    {
        isToggled = !isToggled; 

        objToToggle1.SetActive(isToggled); 
        objToToggle2.SetActive(!isToggled); 
    }
}
