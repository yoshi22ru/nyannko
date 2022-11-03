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
        //非同期でロードを行う    
        var asyncLoad = SceneManager.LoadSceneAsync("menu");

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
        fade.SetActive(true);
        LoadPanel.SetActive(true);
        yield return new WaitForSeconds(4);
    }
}
