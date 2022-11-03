using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Enemy : MonoBehaviour
{
    public static Enemy Instance;

    public AudioClip winSE;

    private Animator anim = null;

   

    

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
        anim = GetComponent<Animator>();
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Enemy_HPManager.Instance.isDead)
            anim.Play("Dead");
            
    }

    //==========================================================================================================================
    // damage prosess
    //==========================================================================================================================
    Bullet E_bullet;
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Bullet"))
        {
            E_bullet = other.GetComponent<Bullet>();
            if (E_bullet.isFriend) {
                Enemy_HPManager.Instance.Damage(other, E_bullet.power);
            }
        }
    }


}

