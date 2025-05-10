using UnityEngine;
using UnityEngine.UI;


public enum Side { Left, Right }

public class SideManager : MonoBehaviour

{
    public static SideManager Instance;
    public Side currentSide = Side.Left;
    public Image leftOverlay, rightOverlay;

    void Awake() => Instance = this;

    public void SwitchSide()
    {
        currentSide = currentSide == Side.Left ? Side.Right : Side.Left;
        UpdateOverlay();
    }

    void UpdateOverlay()
    {
        leftOverlay.color = new Color(0, 0, 0, currentSide == Side.Left ? 0f : 0.4f);
        rightOverlay.color = new Color(0, 0, 0, currentSide == Side.Right ? 0f : 0.4f);
    }
}
