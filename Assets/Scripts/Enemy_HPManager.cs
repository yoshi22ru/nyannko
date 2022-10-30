using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Enemy_HPManager : MonoBehaviour
{
    public GameObject 敵のhp_object = null;
    public GameObject 味方のhp_object = null;
    public int 敵のhp = 0;
    public int 味方のhp = 0;
    public static Enemy_HPManager Instance;
    public AudioClip hitSE;
    public AudioClip winSE;
  

    public bool ishit = false;
    public bool isDead=false;
    public bool isWin = false;
    

    AudioSource audioSource;

    public void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        Text 敵のhp_text = 敵のhp_object.GetComponent<Text>();
        敵のhp_text.text = "HP" + ":" + Enemy_HPManager.Instance.敵のhp;

    }

    // Update is called once per frame
    public void Damage(Collider2D collision, int power)
    {
        Debug.Log(collision.gameObject.name + "と接触した");
        Text 敵のhp_text = 敵のhp_object.GetComponent<Text>();
        Text hp_text = 味方のhp_object.GetComponent<Text>();

        if (敵のhp != 0 && !Player_HPManager.Instance.isDead)
        {
            isDead = false;
            isWin = false;
            敵のhp -= power;
            敵のhp_text.text = "HP" + ":" + 敵のhp;

            ishit = true;
            audioSource.PlayOneShot(hitSE);
            
                

            if ( 敵のhp == 0 && !Player_HPManager.Instance.isDead)
            {
                Debug.Log("勝利");
                isDead = true;
                isWin = true;
                ishit = false;
               
                敵のhp_text.text = "HP" + ":" + 敵のhp;
                敵のhp = 0;
                audioSource.PlayOneShot(winSE);
                



                    hp_text.text = "HP" + ":" + Player_HPManager.Instance.味方のhp;
                    Player_HPManager.Instance.味方のhp = Player_HPManager.Instance.味方のhp;
                    Debug.Log("終了");
                
            }
        }

    }
}
