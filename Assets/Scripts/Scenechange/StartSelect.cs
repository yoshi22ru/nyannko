using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class StartSelect : MonoBehaviour
{
    public AudioClip click;
    AudioSource audioSource;
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        this.gameObject.GetComponent<Button>().onClick.AddListener(startselect);
    }
    void startselect()
    {
        audioSource.PlayOneShot(click);
        SceneManager.LoadScene("SelectBattle");
    }
}
