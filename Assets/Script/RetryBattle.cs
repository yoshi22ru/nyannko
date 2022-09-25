using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RetryBattle : MonoBehaviour
{
    
    public void Retry()
    {
        SceneManager.LoadScene("Battle1");
    }
}
