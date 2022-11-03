using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CharaPop : MonoBehaviour
{
    InfomationCounter info;
    [SerializeField] private int MyNumber;
    [SerializeField] private Image SlotSprite;
    [SerializeField] private Text Cost_text;
    [SerializeField] private Transform PopPos;
    public const float interval = 3f;
    private float interval_count;
    void Start()
    {
        info = GameObject.Find("info").GetComponent<InfomationCounter>();
        this.GetComponent<Button>().onClick.AddListener(Pop);
        if (MyNumber < info.Raid.Count) {
            SlotSprite.sprite = info.Raid[MyNumber].MyItemImage;
            Cost_text.text = info.Raid[MyNumber].CharaCost.ToString();
        }
        else
            SlotSprite.color = new Color(0,0,0,0);
    }

    private void Pop()
    {
        if (interval <= interval_count && info.Raid[MyNumber].CharaCost <= BattleManager.Instance.money && MyNumber < info.Raid.Count) {
            interval_count = 0;
            BattleManager.Instance.account(info.Raid[MyNumber].CharaCost);
            Instantiate(info.Raid[MyNumber].BattleChara, PopPos.position - transform.up*0.5f, Quaternion.Euler(0f, 0f, 0f));
        }
    }
    void FixedUpdate()
    {
        if (interval > interval_count) {
            interval_count += Time.fixedDeltaTime;
        }
    }
}
