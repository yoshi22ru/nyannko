using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BackMenu : MonoBehaviour
{
    //�ȉ��ǋL
    public AudioClip backSE;
    AudioSource audioSource;
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        DontDestroyOnLoad(this.gameObject);
    }
    public void MainMenu()
    {
        audioSource.PlayOneShot(backSE);
        //SceneManager.LoadScene("MainMenu");
    }
}
