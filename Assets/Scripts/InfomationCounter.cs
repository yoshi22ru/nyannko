using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InfomationCounter : MonoBehaviour
{
    // Item counter
    public List<Item> Raid = new List<Item>();
    public int partyMAX = 4;

    void Start()
    {
        DontDestroyOnLoad(this);
    }

    public void IntoRaid(Item chara)
    {
        Raid.Add(chara);

        for (int i = 0; i < Raid.Count; i++) {
            if (Raid[i] != null)
                Debug.Log(i + "番目" +Raid[i].MyItemName);
        }
        if (Raid.Count == 0) {
            Debug.Log("no one in party");
        }
    }

    public void RemoveRaid(Item chara)
    {
        Raid.Remove(chara);
        for (int i = 0; i < Raid.Count; i++) {
            if (Raid[i] != null)
                Debug.Log(i + "番目" +Raid[i].MyItemName);
        }
        if (Raid.Count == 0) {
            Debug.Log("no one in party");
        }
    }
}
