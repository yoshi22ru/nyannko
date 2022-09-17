using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class partyview : MonoBehaviour
{
    [SerializeField] GameObject veiwImagePrefab;
    InfomationCounter info;
    void Start()
    {
        info = GameObject.Find("info").GetComponent<InfomationCounter>();
        if (info == null) return;
        for (int i = 0; i < info.Raid.Count; i++) {
            GameObject obj = Instantiate(veiwImagePrefab, this.transform);
            Image obj_Image = obj.GetComponent<Image>();

            obj_Image.sprite = info.Raid[i].MyItemImage;
        }
    }
}
