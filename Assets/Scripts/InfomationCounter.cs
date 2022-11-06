using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InfomationCounter : MonoBehaviour
{
    // Item counter
    public List<Item> Raid = new List<Item>();
    public int partyMAX = 4;
    [SerializeField] private GameObject text;
    public static InfomationCounter info;

    void Start()
    {
        DontDestroyOnLoad(this);
        info = this;
    }

    public void IntoRaid(Item chara)
    {
        if (Raid.Count >= partyMAX)
        {
            Text text = GameObject.Find("StatusText").GetComponent<Text>();
            text.text = "４人以上はパーティーに入れられないよ";
            return;
        }
        Raid.Add(chara);
    }

    public void RemoveRaid(Item chara)
    {
        Raid.Remove(chara);
    }
}
