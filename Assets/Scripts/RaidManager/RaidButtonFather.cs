using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RaidButtonFather : MonoBehaviour
{
    [SerializeField] private GameObject slotPrefab;
    [SerializeField] private RaidMenu raidMenu;
    private int slotNumber = 12;
    void Start()
    {
        for(int i = 0; i < slotNumber; i++)
        {
            GameObject slotObj = Instantiate(slotPrefab, this.transform);

            RaidButton raidButton = slotObj.GetComponent<RaidButton>();

            //�X���b�g�ɃA�C�e�����Z�b�g������
            if (i < raidMenu.charaDataBase.charadata.Count)
            {
                raidButton.myNumber = i;
            }
            else
            {
                raidButton.myNumber = -1;
            }
        }
    }

}