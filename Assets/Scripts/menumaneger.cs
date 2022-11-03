using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class menumaneger : MonoBehaviour
{
    [SerializeField] private GameObject hensei;
    [SerializeField] private GameObject back;
    [SerializeField] private GameObject start;
    AudioSource audioSource;
    [SerializeField] private AudioClip click;
    [SerializeField] private AudioClip backSE;
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        hensei.GetComponent<Button>().onClick.AddListener(Hensei);
        back.GetComponent<Button>().onClick.AddListener(Back);
        start.GetComponent<Button>().onClick.AddListener(St);
    }

    // Update is called once per frame
    void Hensei()
    {
        audioSource.PlayOneShot(click);
        SceneManager.LoadScene("Hensei");
    }

    void Back()
    {
        audioSource.PlayOneShot(backSE);
        SceneManager.LoadScene("title");
    }
    void St()
    {
        audioSource.PlayOneShot(click);
        SceneManager.LoadScene("SelectBattle");
    }
}
