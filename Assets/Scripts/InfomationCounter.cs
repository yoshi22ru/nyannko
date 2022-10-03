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
    }

    public void RemoveRaid(Item chara)
    {
        Raid.Remove(chara);
    }
}
