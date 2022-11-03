using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BGM : MonoBehaviour
{
    static public BGM instance;
    [SerializeField] private AudioSource bgm;
    private string beforeScene = "SelectBattle";

    private void Start()
    {
        SceneManager.activeSceneChanged += OnActiveSceneChanged;
    }

    void Awake()
    {
        if (instance == null)
        {

            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {

            Destroy(gameObject);
        }
    }

    void OnActiveSceneChanged(Scene prevScene,Scene nextScene)
    {
        if(beforeScene == "SelectBattle" && nextScene.name == "Battle1")
        {
            bgm.Stop();
        }
        else if (beforeScene == "SelectBattle" && nextScene.name == "Battle2")
        {
            bgm.Stop();
        }
        else if (beforeScene == "SelectBattle" && nextScene.name == "Battle3")
        {
            bgm.Stop();
        }

        beforeScene = nextScene.name;
        if (beforeScene == "menu")
        {
            bgm.Play();
        }

    }


}
