using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CharaPop : MonoBehaviour
{
    private InfomationCounter info;
    [SerializeField] private int MyNumber;
    [SerializeField] private Image SlotSprite;
    [SerializeField] private Text SlotText;
    [SerializeField] private Transform PopPos;
    private float interval;
    private float interval_count;
    void Start()
    {
        info = GameObject.Find("info").GetComponent<InfomationCounter>();
        this.GetComponent<Button>().onClick.AddListener(Pop);
        SlotSprite.sprite = info.Raid[MyNumber].MyItemImage;
        SlotText.text = info.Raid[MyNumber].MyItemName;
    }

    private void Pop()
    {
        if (interval <= interval_count)
            Instantiate(info.Raid[MyNumber].BattleChara, PopPos);
    }
    void FixedUpdate()
    {
        if (interval > interval_count) {
            interval_count += Time.fixedDeltaTime;
        }
    }
}
