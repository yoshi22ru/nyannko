using System.Linq;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RaidMenu : MonoBehaviour
{
    public CharaDataBase charaDataBase;
    public InfomationCounter infomationCounter;

    public void RaidInTo(int num)
    {
        if (!infomationCounter.Raid.Contains(charaDataBase.charadata[num]))
        {
            infomationCounter.IntoRaid(charaDataBase.charadata[num]);
        }
        else
        {
            infomationCounter.RemoveRaid(charaDataBase.charadata[num]);
        }
    }
}