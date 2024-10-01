using UnityEngine;

public class AudioManager : MonoBehaviour
{
    static AudioManager instance;
    public static AudioManager Instance => instance;

    void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(this);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    public void Play(AudioSourcePrefab audioSourcePrefab, float volumeScale = 1.0f)
    {
        InstantiateAudioSourcePrefab(audioSourcePrefab, volumeScale);   
    }

    AudioSourcePrefab InstantiateAudioSourcePrefab(AudioSourcePrefab audioSourcePrefab, float volumeScale = 1.0f)
    {
        AudioSourcePrefab audioSourcePrefabInstance = Instantiate(audioSourcePrefab);
        audioSourcePrefabInstance.transform.SetParent(transform);
        audioSourcePrefabInstance.Play(volumeScale);

        return audioSourcePrefabInstance;
    }
}