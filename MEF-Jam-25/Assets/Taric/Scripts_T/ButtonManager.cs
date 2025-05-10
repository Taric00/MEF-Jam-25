using UnityEngine;
using UnityEngine.UI;

public class ButtonManager : MonoBehaviour
{
    private int currentValue = 1;

    public void OnButtonClick()
    {
        Debug.Log("Buton de�eri: " + currentValue);

        currentValue = (currentValue == 1) ? 2 : 1;
    }
}
