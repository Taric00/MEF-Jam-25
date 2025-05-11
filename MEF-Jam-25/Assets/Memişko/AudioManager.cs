//using UnityEngine;

//public class AudioManager : MonoBehaviour
//{
//    [Header("-----------Boss---------")] 
//    [SerializeField] AudioSource m_Source;
//    [SerializeField] AudioSource m_SFX;


//    [Header("-----------Clips---------")]

//    public AudioClip button1;
//    public AudioClip button2;
//    public AudioClip button3;
//    public AudioClip button4;
//    public AudioClip backgroundMusic;

//    private void Start()
//    {
//        m_Source.clip = backgroundMusic;
//        m_Source.Play();
//    }

//    public void PlaySFX(AudioClip clip)
//    {
//        m_SFX.PlayOneShot(clip);
//    }
//}
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    [Header("-----------Boss---------")]
    [SerializeField] AudioSource m_Source;
    [SerializeField] AudioSource m_SFX;

    [Header("-----------Clips---------")]
    public AudioClip button1;
    public AudioClip button2;
    public AudioClip button3;
    public AudioClip button4;
    public AudioClip button5;
    public AudioClip backgroundMusic;
    public float volume;

    private AudioClip[] buttonClips;

    private void Start()
    {
        m_Source.clip = backgroundMusic;
        m_Source.volume = volume; //  %60 ses seviyesi

        m_Source.Play();

        // Buton seslerini diziye al
        buttonClips = new AudioClip[] { button1, button2, button3, button4,button5 };
    }

    public void PlaySFX(AudioClip clip)
    {
        m_SFX.PlayOneShot(clip);
    }

    //  Inspector'dan çaðrýlabilir: rastgele bir buton sesi çal
    public void PlayRandomButtonSound()
    {
        if (buttonClips == null || buttonClips.Length == 0) return;

        int randomIndex = Random.Range(0, buttonClips.Length);
        m_SFX.PlayOneShot(buttonClips[randomIndex]);
    }
}
