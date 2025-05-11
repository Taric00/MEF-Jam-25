using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public static AudioManager instance;

    [Header("-----------Sources---------")]
    [SerializeField] private AudioSource m_Source;
    [SerializeField] private AudioSource m_SFX;    

    [Header("-----------Clips---------")]
    public AudioClip[] buttonClips;
    public AudioClip backgroundMusic;
    public float volume = 0.5f;

    private void Awake()
    {
        // Singleton pattern
        if (instance == null)
            instance = this;
        else
        {
            Destroy(gameObject);
            return;
        }
    }

    private void Start()
    {
        if (m_Source != null && backgroundMusic != null)
        {
            m_Source.clip = backgroundMusic;
            m_Source.volume = volume;
            m_Source.loop = true;
            m_Source.Play();
        }
    }

    public void PlaySFX(AudioClip clip)
    {
        if (clip != null && m_SFX != null)
        {
            m_SFX.PlayOneShot(clip);
        }
    }

    public void PlayRandomButtonSound()
    {
        if (buttonClips != null && buttonClips.Length > 0)
        {
            int randomIndex = Random.Range(0, buttonClips.Length);
            m_SFX.PlayOneShot(buttonClips[randomIndex]);
        }
    }
}
