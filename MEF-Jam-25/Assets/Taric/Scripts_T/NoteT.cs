using UnityEngine;

public enum NoteDirection
{
    Up,
    Down,
    Left,
    Right
}

public class Note : MonoBehaviour
{
    public NoteDirection direction;
}
