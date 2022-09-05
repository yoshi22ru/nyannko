using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneController : MonoBehaviour
{
    void Start()
    {
        DontDestroyOnLoad(this);
    }

    public enum Scene {
        START,
        BATTLE1
    }
    public void ChangeScene(int SceneNum)
    {
        switch (SceneNum) {
        case 0:
            SceneManager.LoadScene("start");
            break;
        case 1:
            SceneManager.LoadScene("Battle");
            break;
        }
    }
}
