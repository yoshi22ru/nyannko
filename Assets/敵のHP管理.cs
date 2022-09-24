using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class　敵のHP管理 : MonoBehaviour
{
    public GameObject 敵のhp_object = null;
    public GameObject 味方のhp_object = null;
    public int 敵のhp = 0;
    public int 味方のhp = 0;
    public static 敵のHP管理 instance;

    public bool isDead=false;

    public void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
    }

    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        Text 敵のhp_text = 敵のhp_object.GetComponent<Text>();
        Text hp_text = 味方のhp_object.GetComponent<Text>();

        if (敵のhp != 0 && !味方のHP管理.Instance.isDead)
        {
            isDead = false;
            敵のhp_text.text = "HP" + ":" + 敵のhp;
            敵のhp += -1;
           
            if ( 敵のhp == 0 && !味方のHP管理.Instance.isDead)
            {
                isDead = true;
                敵のhp_text.text = "HP" + ":" + 敵のhp;
                敵のhp = 0;
                Debug.Log("勝利");

                
                    hp_text.text = "HP" + ":" + 味方のHP管理.Instance.味方のhp;
                    味方のHP管理.Instance.味方のhp = 味方のHP管理.Instance.味方のhp;
                    Debug.Log("終了");
                
            }
        }

    }
}
