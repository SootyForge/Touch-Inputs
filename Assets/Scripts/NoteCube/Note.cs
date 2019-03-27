using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Note : MonoBehaviour
{
    public AudioClip note;
    public AudioSource noteSource;

    public float fadeTime = 0.1f;
    private float startVolume;

    void Start()
    {
        noteSource.clip = note;
        startVolume = noteSource.volume;
    }

    void OnTouchDown()
    {
        noteSource.volume = startVolume;
        noteSource.Play();
    }

    void OnTouchUp()
    {
        StartCoroutine(FadeOut(noteSource, fadeTime));
    }

    void OnTouchExit()
    {
        StartCoroutine(FadeOut(noteSource, fadeTime));
    }

    public static IEnumerator FadeOut(AudioSource audioSource, float fadeTime)
    {
        float startVolume = audioSource.volume;

        while (audioSource.volume > 0)
        {
            audioSource.volume -= startVolume * Time.deltaTime / fadeTime;

            yield return null;
        }

        audioSource.Stop();
        audioSource.volume = startVolume;
    }
}
