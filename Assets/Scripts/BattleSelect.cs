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
    public int StageNum;
    void Start()
    {
        button.onClick.AddListener(BattleStart);
    }
    public void BattleStart()
    {
        StartCoroutine(LoadScene());
    }

    private IEnumerator LoadScene()
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
    public IEnumerator FadeOut()
    {
        LoadPanel.SetActive(true);
        yield return new WaitForSeconds(4);
    }

}
