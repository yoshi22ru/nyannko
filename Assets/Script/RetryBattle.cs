using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RetryBattle : MonoBehaviour
{
    public AudioClip retrySE;
    AudioSource audioSource;
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        DontDestroyOnLoad(this.gameObject);
    }
    public void Retry()
    {
        audioSource.PlayOneShot(retrySE);
        SceneManager.LoadScene("Battle1");
    }
}
