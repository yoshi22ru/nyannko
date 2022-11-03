using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class BackHome : MonoBehaviour
{
    [SerializeField] private AudioClip back;
    AudioSource audioSource;
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        this.gameObject.GetComponent<Button>().onClick.AddListener(backhome);
    }
    void backhome()
    {
        audioSource.PlayOneShot(back);
        SceneManager.LoadScene("title");
    }
}
