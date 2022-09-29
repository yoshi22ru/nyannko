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

    [SerializeField] private GameObject Chara;

    // //�@�L�����N�^�[�̃��x��
    // [SerializeField]
    // private int level = 1;
    // //�@�ő�HP
    // [SerializeField]
    // private int maxHp = 100;
    // //�@HP
    // [SerializeField]
    // private int hp = 100;
    // //�@�f����
    // [SerializeField]
    // private int agility = 5;
    // //�@��
    // [SerializeField]
    // private int power = 10;
    // //�@�ł��ꋭ��
    // [SerializeField]
    // private int strikingStrength = 10;

    public string MyItemName { get => itemName; }
    public Sprite MyItemImage { get => itemImage; }
    public GameObject BattleChara { get => Chara; }



    // public void SetLevel(int level)
    // {
    //     this.level = level;
    // }

    // public int GetLevel()
    // {
    //     return level;
    // }

    // public void SetMaxHp(int hp)
    // {
    //     this.maxHp = hp;
    // }

    // public int GetMaxHp()
    // {
    //     return maxHp;
    // }

    // public void SetHp(int hp)
    // {
    //     this.hp = Mathf.Max(0, Mathf.Min(GetMaxHp(), hp));
    // }

    // public int GetHp()
    // {
    //     return hp;
    // }

    // public void SetAgility(int agility)
    // {
    //     this.agility = agility;
    // }

    // public int GetAgility()
    // {
    //     return agility;
    // }

    // public void SetPower(int power)
    // {
    //     this.power = power;
    // }

    // public int GetPower()
    // {
    //     return power;
    // }

    // public void SetStrikingStrength(int strikingStrength)
    // {
    //     this.strikingStrength = strikingStrength;
    // }

    // public int GetStrikingStrength()
    // {
    //     return strikingStrength;
    // }

}
