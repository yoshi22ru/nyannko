using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class titleManager : MonoBehaviour
{
    [SerializeField] private GameObject Startgame;
    Button startgame;
    [SerializeField] private GameObject Setting;
    Button setting;
    [SerializeField] private GameObject Close;
    public List<GameObject> iroiro = new List<GameObject>();

    public GameObject SettingPanel;
    void Start()
    {
        Startgame.GetComponent<Button>().onClick.AddListener(StartGame);
        Setting.GetComponent<Button>().onClick.AddListener(OpenSetting);
        Close.GetComponent<Button>().onClick.AddListener(OpenSetting);
    }

    private void StartGame()
    {
        SceneManager.LoadScene("menu");
    }
    private void OpenSetting()
    {
        if (SettingPanel.activeSelf) {
            SettingPanel.SetActive(false);
            Startgame.SetActive(true);
            for (int i = 0; i < iroiro.Count;i++)
            {
                iroiro[i].SetActive(true);
            }
        }
        else {
            SettingPanel.SetActive(true);
            Startgame.SetActive(false);
            for (int i = 0; i < iroiro.Count; i++)
            {
                iroiro[i].SetActive(false);
            }
        }
    }
}
