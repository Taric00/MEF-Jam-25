using System.Collections;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;

public class ShockWaveManager : MonoBehaviour
{
    [SerializeField] private float _shockWaveTime = 0.75f;

    private Coroutine _shockWaveRoutine;
    private Material _material;

    private static int _waveDistanceFromCenter = Shader.PropertyToID("_WaveDistanceFromCenter");

    private void Awake()
    {
        _material = GetComponent<SpriteRenderer>().material;
    }

    private void Update()
    {
        if(Keyboard.current.eKey.wasPressedThisFrame)
        {
            Debug.Log("E bastin");
            CallShockWave();
            Debug.Log("CallShockWave çağrildi");
        }
    }

    public void CallShockWave()
    {
        _shockWaveRoutine = StartCoroutine(ShockWaveAction(-0.1f, 1f));
    }

    private IEnumerator ShockWaveAction(float startPos, float endPos)
    {
        _material.SetFloat(_waveDistanceFromCenter, startPos);

        float lerpedAmount = 0;
        float elapsedTime = 0;
        while (elapsedTime < _shockWaveTime)
        {
            elapsedTime += Time.deltaTime;
            lerpedAmount = Mathf.Lerp(startPos, endPos, elapsedTime / _shockWaveTime);
            _material.SetFloat(_waveDistanceFromCenter, lerpedAmount);
            yield return null;
        }
    }
}
