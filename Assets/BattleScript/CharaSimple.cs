using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharaSimple : MonoBehaviour
{
    [Header("Enemy or Friend")]
    public bool isFriend;
    [Header("Propaty")]
    public int HP = 10;
    public int power = 1;
    [SerializeField] private float speed = 1.0f;
    public float attackRange;
    [Header("animation")]
    private Animator anim;
    [SerializeField] private float attackAnimationLength;
    [Header("This↓ mean the length of Time")]
    [Header("which from starting animation to taking attack")]
    [SerializeField] private float damageTime;
    private float animetime;

    // variable to attack
    [SerializeField] private GameObject bullet;
    private bool dam;


    public LayerMask enemyForMe;
    private bool isAttacking;
    private bool castHit;
    private RaycastHit Hit;

    // damage
    Bullet E_bullet;

    void FixedUpdate()
    {
        if (!isAttacking) {// if I`m not attacking
            checkRange();   // check enemy in attack range
            if (castHit) {// if enemy is in attack range
                attack();// start attack
            }
            else {// if there is no enemy in attack range
                walk();// walk to enemy catsle
            }
        }
        else {// if I`m attacking
            if (animetime >= attackAnimationLength) // if attack ainme is ended
                endAttack();// end attack
            else {
                animetime += Time.deltaTime;
                damage();
            }
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("bullet"))
        {
            E_bullet = other.GetComponent<Bullet>();
            HP -= E_bullet.power;
        }
    }

    private void checkRange()
    {
        if (isFriend)
            castHit = Physics.Raycast(this.transform.position, transform.right, attackRange, enemyForMe);
        else
            castHit = Physics.Raycast(this.transform.position, -transform.right, attackRange, enemyForMe);
    }

    private void walk()
    {
        if (isFriend) {
            this.transform.rotation = Quaternion.Euler(new Vector3(0.0f, 0.0f, 0.0f));
            transform.Translate(transform.right * speed / 10f);
        }
        else {
            this.transform.rotation = Quaternion.Euler(new Vector3(0.0f, 180.0f, 0.0f));
            transform.Translate(transform.right * speed / 10f);
        }
    }

    private void attack()
    {
        anim.SetBool("isAttack", true);
        isAttacking = true;
        dam = true;
    }
    
    private void endAttack()
    {
        animetime += Time.deltaTime;

        if (animetime >= attackAnimationLength) {
            animetime = 0.0f;
        }
    }

    private void damage()
    {
        if (damageTime <= animetime && dam) {
            Instantiate(bullet, this.transform.position, Quaternion.Euler(0.0f, 0.0f, 0.0f), this.transform);
            dam = false;
        }
    }
}
