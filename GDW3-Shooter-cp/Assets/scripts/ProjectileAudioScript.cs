using UnityEngine;

public class ProjectileAudioScript : MonoBehaviour
{
    public AudioClip projectileSound;
    private AudioSource audioSource;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        if (audioSource == null)
        {
            audioSource = gameObject.AddComponent<AudioSource>();
        }
        audioSource.clip = projectileSound;
        audioSource.loop = false;
        audioSource.Play();
    }
}
