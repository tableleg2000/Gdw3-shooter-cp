using UnityEngine;

public class DyingSoundEnemy : MonoBehaviour
{

    public AudioClip deathSound; // Assign your audio clip in the Inspector

    void OnDeath()
    { // Or any event that triggers the dying sound
        AudioSource audioSource = GetComponent<AudioSource>();
        if (audioSource != null && deathSound != null)
        {
            audioSource.PlayOneShot(deathSound);
        }
    }
}