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

    public bool isDead=false;

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
       
    }

    // Update is called once per frame
    void Update()
    {
        Text hp_text = 味方のhp_object.GetComponent<Text>();
        Text 敵のhp_text = 敵のhp_object.GetComponent<Text>();

        if ( 味方のhp != 0 && !敵のHP管理.instance.isDead)
        {
            isDead = false;
            hp_text.text = "HP" + ":" + 味方のhp;
            味方のhp+= -1;
            

            if ( 味方のhp == 0 && !敵のHP管理.instance.isDead)
            {
                isDead = true;
                hp_text.text = "HP" + ":" + 味方のhp;
                味方のhp = 0;
                Debug.Log("敗北");

                
                    敵のhp_text.text = "HP" + ":" + 敵のHP管理.instance.敵のhp;
                    敵のHP管理.instance.敵のhp = 敵のHP管理.instance.敵のhp;
                    Debug.Log("終了");
                
            }
            
            
        }    

    }
}
