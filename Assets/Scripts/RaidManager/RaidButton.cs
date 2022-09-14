using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RaidButton : MonoBehaviour
{
    [Header("don`t touch my number")]
    public int myNumber = -1;
    RaidMenu raidMenu;
    [SerializeField] private Image charaimage;

    void Start()
    {
        GetComponent<Button>().onClick.AddListener(Raid);
        raidMenu = GameObject.Find("info").GetComponent<RaidMenu>();
        if (myNumber == -1) 
        {
            charaimage.color = new Color(0, 0, 0, 0);
        }
        else {
            charaimage.sprite = raidMenu.charaDataBase.charadata[myNumber].MyItemImage;
        }
    }

    void Raid()
    {
        if (myNumber != -1) {
            raidMenu.RaidInTo(myNumber);
        }
    }
}