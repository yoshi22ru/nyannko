using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class titleManager : MonoBehaviour
{
    [SerializeField] private GameObject Startgame;
    Button startgame;
    [SerializeField] private GameObject Close;
    [SerializeField] private GameObject LoadPanel;
    [SerializeField] private GameObject fade;
    [SerializeField] private AudioClip click;
    AudioSource audioSource;

    public List<GameObject> iroiro = new List<GameObject>();

    public GameObject SettingPanel;
    void Start()
    {
        audioSource = GetComponent<AudioSource>();

        Startgame.GetComponent<Button>().onClick.AddListener(LoadButton);
    }

    void LoadButton()
    {
       audioSource.PlayOneShot(click);
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
}
