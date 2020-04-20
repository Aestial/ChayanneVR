using System;
using UnityEngine;

public class PlayAudioFX : MonoBehaviour
{
    [Serializable]
    public struct AudioFX
    {
        public AudioClip clip;
        public float volume;
        public float pitch;
    }

    [SerializeField] AudioFX fX = default; 
    AudioSource audioSource;

    public void PlayFX()
    {
        PlayOneShot(fX);
    }
    void Start()
    {
        audioSource = GetComponent<AudioSource>();        
    }
    void PlayOneShot(AudioFX fx)
    {
        float oldPitch = audioSource.pitch;
        audioSource.pitch = fx.pitch;
        audioSource.PlayOneShot(fx.clip, fx.volume);
        audioSource.pitch = oldPitch;
    }
}
