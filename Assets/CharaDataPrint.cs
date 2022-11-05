using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CharaDataPrint : MonoBehaviour
{
    private Text text;
    public static CharaDataPrint dataPrint;
    [SerializeField] private CharaDataBase dataBase;
    void Start()
    {
        text = this.GetComponent<Text>();
        dataPrint = this;
    }
    public void PrintData(Item data)
    {
        CharaSimple chara = data.BattleChara.GetComponent<CharaSimple>();
        text.text = "name : " + data.MyItemName + "\n" + "Cost : " + data.CharaCost + "\n" + 
        "HP : " + chara.HP + "\n" + "Power : " + chara.power + "\n" +
        "range : " + chara.attackRange;
    }
}
