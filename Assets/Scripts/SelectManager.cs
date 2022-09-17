using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SelectManager : MonoBehaviour
{
    public void SelectBattle(int StageNum)
    {
        switch (StageNum) {
        case 1:
            SceneManager.LoadScene("Batte1");
            break;
        case 2:
            SceneManager.LoadScene("Batte2");
            break;
        case 3:
            SceneManager.LoadScene("Batte3");
            break;
        }
    }
}
