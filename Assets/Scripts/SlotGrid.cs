using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlotGrid : MonoBehaviour
{
    [SerializeField]
    private GameObject slotPrefab;
    private int slotNumber = 12;
    [SerializeField]
    private Item[] allItems;
    void Start()
    {
        for(int i = 0; i < slotNumber; i++)
        {
            GameObject slotObj = Instantiate(slotPrefab, this.transform);

            Slot slot = slotObj.GetComponent<Slot>();

            //スロットにアイテムをセットしたい
            if (i < allItems.Length)
            {
                slot.Setitem(allItems[i]);
            }
            else
            {
                slot.Setitem(null);
            }
        }
    }

}
