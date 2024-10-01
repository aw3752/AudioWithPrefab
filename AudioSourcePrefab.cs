using System;
using System.Collections;
using UnityEngine;
using UnityEngine.Events;

[ExecuteInEditMode]
[RequireComponent(typeof(AudioSource))]
public class AudioSourcePrefab : MonoBehaviour
{
    [SerializeField]
    AudioSource audioSource;
    [SerializeField] [Range(0.0f, 1.0f)] [Tooltip("Audio Source의 Volume의 역할을 대신함")]
    float originalVolume;

    UnityEvent<AudioSourcePrefab> whenDestroyed;

    public UnityEvent<AudioSourcePrefab> WhenDestroyed => whenDestroyed;

    public AudioSource AudioSource => audioSource;
    public float Length => audioSource.clip.length;

    void Awake()
    {
        whenDestroyed = new UnityEvent<AudioSourcePrefab>();
    }

    public void TestPlay()
    {
        audioSource.volume = originalVolume;
        audioSource.Play();
    }

    public void Play(float volumeScale = 1.0f)
    {
        audioSource.volume = originalVolume * volumeScale;
        audioSource.Play();
        StartCoroutine(PlayAndDestroy());
    }

    IEnumerator PlayAndDestroy()
    {
        yield return new WaitForSeconds(Length);
        whenDestroyed.Invoke(this);
		Destroy(gameObject);
    }
}
