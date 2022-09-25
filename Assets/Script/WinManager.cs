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
        if(敵のHP管理.Instance.isWin)
        {
            Debug.Log("勝利パネルを表示");
            WinPanel.SetActive(true);
        }
    }
}
