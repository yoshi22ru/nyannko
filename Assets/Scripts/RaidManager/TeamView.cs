using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TeamView : MonoBehaviour
{
    private InfomationCounter info;
    [SerializeField] private List<Image> raid = new List<Image>();

    void Start()
    {
        info = GameObject.Find("info").GetComponent<InfomationCounter>();
    }
    void Update()
    {
        for (int i = 0; i < info.partyMAX; i++) {
            if (info.Raid[i] != null) {
                raid[i].sprite = info.Raid[i].MyItemImage;
            }
            else {
                raid[i].sprite = null;
            }
        }
    }
}