using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class GoLevelUpScene : MonoBehaviour
{
    [SerializeField] private Button button;
    void Start()
    {
        button.onClick.AddListener(backToMainMenu);
    }
    void backToMainMenu()
    {
        SceneManager.LoadScene("LevelUp");
    }
}
