using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Items",menuName = "Items/item")]
public abstract class Item : ScriptableObject
{
    [SerializeField]
    private string itemName;
    [SerializeField]
    private Sprite itemImage;

    [SerializeField]
    private GameObject Chara;
    [SerializeField]
    private int Cost;

    public string MyItemName { get => itemName; }
    public Sprite MyItemImage { get => itemImage; }
    public GameObject BattleChara { get => Chara; }
    public int CharaCost { get => Cost; }

}