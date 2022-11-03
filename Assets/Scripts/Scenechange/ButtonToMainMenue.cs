using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ButtonToMainMenue : MonoBehaviour
{
    [SerializeField] private Button button;
    [SerializeField] private AudioClip back;
    AudioSource audioSource;
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        button.onClick.AddListener(backToMainMenu);
        DontDestroyOnLoad(this.gameObject);
    }
    void backToMainMenu()
    {
        audioSource.PlayOneShot(back);
        SceneManager.LoadScene("menu");
    }
}
