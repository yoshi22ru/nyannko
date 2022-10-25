using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LoseManager : MonoBehaviour
{
    public GameObject LosePanel;
    public static LoseManager Instance;

    void Awake()
    {
        if (Instance = null)
            Instance = this;
    }

    // Update is called once per frame
    void Update()
    {
        if(Player_HPManager.Instance.isLose)
        {
            Debug.Log("”s–kƒpƒlƒ‹‚ð•\Ž¦");
            LosePanel.SetActive(true);
        }
    }
}
