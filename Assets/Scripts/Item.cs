using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Items",menuName = "Items/item")]
public abstract class Item : ScriptableObject
{
    //�L�����N�^�[��
    [SerializeField]
    private string itemName;
    //�L�����N�^�[�摜
    [SerializeField]
    private Sprite itemImage;



}
