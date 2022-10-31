using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class BattleManager : MonoBehaviour
{
    public static BattleManager Instance;
    [SerializeField] private Button stop;
    //[SerializeField] private Button LevelUp;
    [SerializeField] private Text Money;
    [SerializeField] private int[] levelUpMoney;
    [SerializeField] private GameObject Pause;
    [SerializeField] private Button quit;
    [SerializeField] private Button menuwin;
    [SerializeField] private Button menulose;
    [SerializeField] private GameObject notactivecanvas;
    Button setting;
    int nowLevel;
    public float money;
    int amount;
    public float[] moneySpeed;

    void Start()
    {
        Instance=this;
        nowLevel = 0;
        stop.onClick.AddListener(Stop);
        quit.onClick.AddListener(Quit);
        menuwin.onClick.AddListener(menuw);
        menulose.onClick.AddListener(menul);
//        LevelUp.onClick.AddListener(levelUp);
    }

    void FixedUpdate()
    {
        money += Time.deltaTime * moneySpeed[nowLevel];

        amount = Mathf.RoundToInt(money);
        Money.text = "$" + amount;
    }

    private void Stop()
    {
        if (Time.timeScale == 0.0f) 
        {
            Time.timeScale = 1.0f;
            Pause.SetActive(false);
            notactivecanvas.SetActive(true);
        }
        else 
        {
            Time.timeScale = 0.0f;
            notactivecanvas.SetActive(false);
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
        money -= (float)value;
    }

    private void Quit()
    {
        Time.timeScale = 1.0f;
        SceneManager.LoadScene("menu");
    }

    private void menuw()
    {
        SceneManager.LoadScene("menu");
    }
    private void menul()
    {
        SceneManager.LoadScene("menu");
    }

}