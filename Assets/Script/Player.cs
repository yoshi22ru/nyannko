using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    public static Player instance;

    AudioSource audioSource;

    private Animator anim = null;

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
        anim = GetComponent<Animator>();
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Player_HPManager.Instance.isDead)     
        anim.Play("Dead");
    }

    //==========================================================================================================================
    // damage prosess
    //==========================================================================================================================
    Bullet E_bullet;
    [SerializeField] private GameObject Player_HP;
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Bullet"))
        {
            E_bullet = other.GetComponent<Bullet>();
            if (!E_bullet.isFriend) {
                HP -= E_bullet.power;
                Debug.Log("ダメージ" + E_bullet.power);
                //dam_text = Instantiate(text, this.transform.position, Quaternion.Euler(0f, 0f, 0f)).GetComponent<DamageText>();
                //dam_text.damage = E_bullet.power;
                if (HP <= 0) {
                    Destroy(this.gameObject);
                }
            }
        }
    }

}
