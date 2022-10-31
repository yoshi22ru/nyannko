using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    [SerializeField]
    AudioSource bgmAudioSource;
    [SerializeField]
    AudioSource seAudioSource;
    public static SoundManager Instance;

    void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
    }
    public float BgmVolume
    {
        get
        {
            return bgmAudioSource.volume;
        }
        set
        {
            bgmAudioSource.volume = Mathf.Clamp01(value);
        }
    }
    public float SeVolume
    {
        get
        {
            return seAudioSource.volume;
        }
        set
        {
            seAudioSource.volume = Mathf.Clamp01(value);
        }
    }
    void Start()
    {
        //GameObject soundManager = CheckOtherSoundManager();
        //bool checkResult = soundManager != null && soundManager != gameObject;
        //if (checkResult)
        {
            Destroy(gameObject);
        }
        //DontDestroyOnLoad(gameObject);
    }
    //GameObject CheckOtherSoundManager()
    
        //return GameObject.FindGameObjectWithTag("SoundManager");
    
    public void PlayBgm(AudioClip clip)
    {
        bgmAudioSource.clip = clip;
        if (clip == null)
        {
            return;
        }
        bgmAudioSource.Play();
    }
    public void StopBgm(AudioClip clip)
    {
        bgmAudioSource.Stop();
        clip = null;
        return;
    }
    public void PlaySe(AudioClip clip)
    {

        if (clip == null)
        {
            return;
        }
        seAudioSource.PlayOneShot(clip);

    }

}