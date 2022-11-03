using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class StartRaid : MonoBehaviour
{
    [SerializeField] private Button button;
    [SerializeField] private AudioClip click;
    AudioSource audioSource;
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        button.onClick.AddListener(RaidStart);
    }
    void RaidStart()
    {
        audioSource.PlayOneShot(click);
        SceneManager.LoadScene("Hensei");
    }
}
