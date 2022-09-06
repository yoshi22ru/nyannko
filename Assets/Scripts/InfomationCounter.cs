using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InfomationCounter : MonoBehaviour
{
    // Item counter
    public Item[] Raid = null;
    [SerializeField] private int raidMax;

    void Start()
    {
        DontDestroyOnLoad(this);
    }

    public void LeadRaid(int Num, Item chara)
    {
        if (Num < 0) return;

        Raid[Num] = chara;

        for (int i = 0; i < raidMax; i++) {
            if (Raid[i] != null)
                Debug.Log(Raid[i].MyItemName);
        }
    }
}
