using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WinManager : MonoBehaviour
{
    public GameObject WinPanel;
    public static WinManager Instance;


    void Awake()
    {
        if (Instance = null)
            Instance = this;
    }
    

    // Update is called once per frame
    void Update()
    {
        if(Enemy_HPManager.Instance.isWin)
        {
            Debug.Log("�����p�l�����");
            WinPanel.SetActive(true);
        }
    }
}
