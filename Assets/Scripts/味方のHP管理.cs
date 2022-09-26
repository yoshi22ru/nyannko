using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class 味方のHP管理 : MonoBehaviour
{
    public GameObject 味方のhp_object = null;
    public GameObject 敵のhp_object = null;
    public int 味方のhp = 0;
    public int 敵のhp = 0;
    public static 味方のHP管理 Instance;
    public AudioClip hitSE;
    public AudioClip loseSE;

    public bool ishit = false;
    public bool isDead=false;
    public bool isLose = false;

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
        Text hp_text = 味方のhp_object.GetComponent<Text>();
        hp_text.text = "HP" + ":" + 味方のHP管理.Instance.味方のhp;
    }

    // Update is called once per frame
    void OnCollisionEnter(Collision collision)
    {
        Debug.Log(collision.gameObject.name + "と接触");
        Text hp_text = 味方のhp_object.GetComponent<Text>();
        Text 敵のhp_text = 敵のhp_object.GetComponent<Text>();

        if (味方のhp != 0 && !敵のHP管理.Instance.isDead)
        {
            isDead = false;
            isLose = false;
            hp_text.text = "HP" + ":" + 味方のhp;
            味方のhp -= 1;

            

            ishit = true;
            audioSource.PlayOneShot(hitSE);
            
                
            
            

            if ( 味方のhp == 0 && !敵のHP管理.Instance.isDead)
            {
                Debug.Log("敗北");
                isDead = true;
                isLose = true;
                ishit = false;
                hp_text.text = "HP" + ":" + 味方のhp;
                味方のhp = 0;               
                audioSource.PlayOneShot(loseSE);
                



                    敵のhp_text.text = "HP" + ":" + 敵のHP管理.Instance.敵のhp;
                    敵のHP管理.Instance.敵のhp = 敵のHP管理.Instance.敵のhp;
                    Debug.Log("終了");
                
            }
            
            
        }    

    }
}
