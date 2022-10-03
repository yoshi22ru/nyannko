using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class BattleManager : MonoBehaviour
{
    [SerializeField] private Button stop;
    //[SerializeField] private Button LevelUp;
    [SerializeField] private Text Money;
    [SerializeField] private int[] levelUpMoney;
    [SerializeField] private GameObject Pause;
    [SerializeField] private Button quit;
    Button setting;
    int nowLevel;
    float money;
    int amount;
    public float[] moneySpeed;

    void Start()
    {
        nowLevel = 0;
        stop.onClick.AddListener(Stop);
        quit.onClick.AddListener(Quit);
//        LevelUp.onClick.AddListener(levelUp);
    }

    void FixedUpdate()
    {
        money += Time.deltaTime * moneySpeed[nowLevel];

        amount = Mathf.RoundToInt(money);
        Money.text = amount + "円";
    }

    private void Stop()
    {
        if (Time.timeScale == 0.0f) 
        {
            Time.timeScale = 1.0f;
            Pause.SetActive(false);
        }
        else 
        {
            Time.timeScale = 0.0f;
            Pause.SetActive(true);
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

    private void Quit()
    {
        Time.timeScale = 1.0f;
        SceneManager.LoadScene("menu");
    }
}