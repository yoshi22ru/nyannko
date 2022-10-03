using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class BackHome : MonoBehaviour
{
    void Start()
    {
        this.gameObject.GetComponent<Button>().onClick.AddListener(backhome);
    }
    void backhome()
    {
        SceneManager.LoadScene("title");
    }
}
