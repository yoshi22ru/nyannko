using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class BattleSelect : MonoBehaviour
{
    [SerializeField] private SelectManager select;
    [SerializeField] private Button button;
    [SerializeField] private GameObject LoadPanel;
    //�ȉ��ǋL
    [SerializeField] private AudioClip styutugekiSE;
    AudioSource audioSource;
    public int StageNum;
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        button.onClick.AddListener(BattleStart);
    }
    public void BattleStart()
    {
        audioSource.PlayOneShot(styutugekiSE);
        if (StageNum == 1)
            StartCoroutine(LoadScene1());
        else if (StageNum == 2)
            StartCoroutine(LoadScene2());
        else if (StageNum == 3)
            StartCoroutine(LoadScene3());
    }

    private IEnumerator LoadScene1()
    {
        //�񓯊��Ń��[�h���s��    
        var asyncLoad = SceneManager.LoadSceneAsync("Battle1");

        //���[�h���������Ă��A�V�[���̃A�N�e�B�u���������Ȃ�
        asyncLoad.allowSceneActivation = false;

        //�t�F�[�h�A�E�g�ƃ��[�h�ҋ@
        yield return FadeOut();

        //���[�h�������������ɃV�[���̃A�N�e�B�u����������
        asyncLoad.allowSceneActivation = true;

        //���[�h����������܂ő҂�
        yield return asyncLoad;

    }
    private IEnumerator LoadScene2()
    {
        //�񓯊��Ń��[�h���s��    
        var asyncLoad = SceneManager.LoadSceneAsync("Battle2");

        //���[�h���������Ă��A�V�[���̃A�N�e�B�u���������Ȃ�
        asyncLoad.allowSceneActivation = false;

        //�t�F�[�h�A�E�g�ƃ��[�h�ҋ@
        yield return FadeOut();

        //���[�h�������������ɃV�[���̃A�N�e�B�u����������
        asyncLoad.allowSceneActivation = true;

        //���[�h����������܂ő҂�
        yield return asyncLoad;

    }
    private IEnumerator LoadScene3()
    {
        //�񓯊��Ń��[�h���s��    
        var asyncLoad = SceneManager.LoadSceneAsync("Battle3");

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
        LoadPanel.SetActive(true);
        yield return new WaitForSeconds(4);
    }

}
