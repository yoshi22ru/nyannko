using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BattleSelect : MonoBehaviour
{
    [SerializeField] private SelectManager select;
    [SerializeField] private Button button;
    public int StageNum;
    void Start()
    {
        button.onClick.AddListener(BattleStart);
    }
    public void BattleStart()
    {
        select.SelectBattle(StageNum);
    }
}
