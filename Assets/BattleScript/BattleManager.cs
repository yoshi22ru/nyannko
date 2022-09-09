using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BattleManager : MonoBehaviour
{
    [SerializeField] private Button stop;
    [SerializeField] private Button LevelUp;
    [SerializeField] private Text Money;
    [SerializeField] private int[] levelUpMoney;
    int nowLevel;
    float money;
    int amount;
    public float[] moneySpeed;

    void Start()
    {
        stop.onClick.AddListener(Stop);
        LevelUp.onClick.AddListener(levelUp);
    }

    void FixedUpdate()
    {
        money += Time.deltaTime * moneySpeed[nowLevel];

        amount = Mathf.RoundToInt(money);
        Money.text = amount + "円";
    }

    private void Stop()
    {
        if (Time.timeScale == 0.0f) {
            Time.timeScale = 1.0f;
        }
        else {
            Time.timeScale = 0.0f;
        }
    }

    private void levelUp()
    {
        if (money >= levelUpMoney[nowLevel])
        {
            money -= levelUpMoney[nowLevel];
            nowLevel++;
        }
    }

    public void account(int value)
    {
        money -= value;
    }
}