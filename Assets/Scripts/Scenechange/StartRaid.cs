using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class StartRaid : MonoBehaviour
{
    [SerializeField] private Button button;
    void Start()
    {
        button.onClick.AddListener(RaidStart);
    }
    void RaidStart()
    {
        SceneManager.LoadScene("Hensei");
    }
}
