using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InfomationCounter : MonoBehaviour
{
    // Item counter
    public List<Item> Raid = new List<Item>();

    void Start()
    {
        DontDestroyOnLoad(this);
    }

    public void LeadRaid(Item chara)
    {
        Raid.Add(chara);

        for (int i = 0; i < Raid.Count; i++) {
            if (Raid[i] != null)
                Debug.Log(i + "番目" +Raid[i].MyItemName);
        }
    }

    public void RemoveRaid(Item chara)
    {
        Raid.Remove(chara);
    }
}
