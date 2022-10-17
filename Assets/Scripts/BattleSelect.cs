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
        //非同期でロードを行う    
        var asyncLoad = SceneManager.LoadSceneAsync("Battle1");

        //ロードが完了しても、シーンのアクティブ化を許可しない
        asyncLoad.allowSceneActivation = false;

        //フェードアウトとロード待機
        yield return FadeOut();

        //ロードが完了した時にシーンのアクティブ化を許可する
        asyncLoad.allowSceneActivation = true;

        //ロードが完了するまで待つ
        yield return asyncLoad;

    }
    public IEnumerator FadeOut()
    {
        LoadPanel.SetActive(true);
        yield return new WaitForSeconds(4);
    }

}
