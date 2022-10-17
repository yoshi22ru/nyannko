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
    [SerializeField] private GameObject LoadPanel;
    [SerializeField] private GameObject fade;

    public List<GameObject> iroiro = new List<GameObject>();

    public GameObject SettingPanel;
    void Start()
    {
        Startgame.GetComponent<Button>().onClick.AddListener(LoadButton);
        Setting.GetComponent<Button>().onClick.AddListener(OpenSetting);
        Close.GetComponent<Button>().onClick.AddListener(OpenSetting);
    }

    void LoadButton()
    {
       StartCoroutine(LoadScene());
    }

    private IEnumerator LoadScene()
    {
        //�񓯊��Ń��[�h���s��    
        var asyncLoad = SceneManager.LoadSceneAsync("menu");

        //���[�h���������Ă��A�V�[���̃A�N�e�B�u���������Ȃ�
        asyncLoad.allowSceneActivation = false;

        //�t�F�[�h�A�E�g�ƃ��[�h�ҋ@
        yield return FadeOut();

        //���[�h�������������ɃV�[���̃A�N�e�B�u����������
        asyncLoad.allowSceneActivation = true;

        //���[�h����������܂ő҂�
        yield return asyncLoad;
    }

    public IEnumerator FadeOut()
    {
        fade.SetActive(true);
        LoadPanel.SetActive(true);
        yield return new WaitForSeconds(4);
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
