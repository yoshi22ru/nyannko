using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Items",menuName = "Items/item")]
public abstract class Item : ScriptableObject
{
    //キャラクター名
    [SerializeField]
    private string itemName;
    //キャラクター画像
    [SerializeField]
    private Sprite itemImage;
    //　キャラクターのレベル
    [SerializeField]
    private int level = 1;
    //　最大HP
    [SerializeField]
    private int maxHp = 100;
    //　HP
    [SerializeField]
    private int hp = 100;
    //　素早さ
    [SerializeField]
    private int agility = 5;
    //　力
    [SerializeField]
    private int power = 10;
    //　打たれ強さ
    [SerializeField]
    private int strikingStrength = 10;

    public string MyItemName { get => itemName; }
    public Sprite MyItemImage { get => itemImage; }



    public void SetLevel(int level)
    {
        this.level = level;
    }

    public int GetLevel()
    {
        return level;
    }

    public void SetMaxHp(int hp)
    {
        this.maxHp = hp;
    }

    public int GetMaxHp()
    {
        return maxHp;
    }

    public void SetHp(int hp)
    {
        this.hp = Mathf.Max(0, Mathf.Min(GetMaxHp(), hp));
    }

    public int GetHp()
    {
        return hp;
    }

    public void SetAgility(int agility)
    {
        this.agility = agility;
    }

    public int GetAgility()
    {
        return agility;
    }

    public void SetPower(int power)
    {
        this.power = power;
    }

    public int GetPower()
    {
        return power;
    }

    public void SetStrikingStrength(int strikingStrength)
    {
        this.strikingStrength = strikingStrength;
    }

    public int GetStrikingStrength()
    {
        return strikingStrength;
    }

}
