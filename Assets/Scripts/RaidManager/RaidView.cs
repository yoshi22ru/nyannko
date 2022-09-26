using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RaidView : MonoBehaviour
{
    private InfomationCounter info;
    [SerializeField] private List<Image> raid = new List<Image>();

    void Start()
    {
        info = GameObject.Find("info").GetComponent<InfomationCounter>();
    }
    void Update()
    {
        int i;
        for (i = 0; i < info.Raid.Count; i++) {
            raid[i].sprite = info.Raid[i].MyItemImage;
            raid[i].color = Color.white;
        }
        if (i < info.partyMAX) {
            for (;i < info.partyMAX; i++) {
                raid[i].sprite = null;
                raid[i].color = Color.clear;
            }
        }
    }
}