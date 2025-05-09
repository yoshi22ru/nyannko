using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class CharaSimple : MonoBehaviour
{
    [Header("Enemy or Friend")]
    public bool isFriend;
    [Header("Propaty")]
    public int HP = 10;
    public int power = 1;
    public float speed = 1.0f;
    public float attackRange;
    [SerializeField] private float vertical_challenge = 0.0f;
    [Header("animation")]
    private Animator anim;
    [SerializeField] private float attackAnimationLength;
    [Header("This↓ mean the length of Time")]
    [Header("which from starting animation to taking attack")]
    [SerializeField] private float damageTime;
    private float animetime;
    [SerializeField] private AudioClip attackse;
    AudioSource audioSource;

    // variable to attack
    [SerializeField] private GameObject bullet;

    public LayerMask enemyForMe;
    private bool isAttacking = false;
    private bool castHit;
    private RaycastHit Hit;

    // damage
    Bullet E_bullet;

    GameObject attacker;

    private void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    void FixedUpdate()
    {
        if (!isAttacking) {// if I`m not attacking
            checkRange();   // check enemy in attack range
            if (castHit) {// enemy is in attack range
                attack();// start attack
            }
            else {// there is no enemy in attack range
                walk();// walk to enemy catsle
            }
        }
        else {// if I`m attacking
            animetime += Time.deltaTime;
            damage();
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Bullet"))
        {
            E_bullet = other.GetComponent<Bullet>();
            if (E_bullet.isFriend != isFriend) {
                HP -= E_bullet.power;
                Debug.Log("ダメージ" + E_bullet.power);
                if (HP <= 0) {
                    Destroy(this.gameObject);
                }
            }
        }
        if (other.CompareTag("Frag"))
        {
            E_bullet = other.GetComponent<Bullet>();
            if (E_bullet.isFriend != isFriend) {
                isFriend = E_bullet.isFriend;
                if (isFriend) {
                }
            }
        }
    }

    private void checkRange()
    {
        if (isFriend) {
            castHit = Physics2D.BoxCast(this.transform.position, new Vector2(0.1f, 1f), 0f, transform.right, attackRange / 2f, enemyForMe);
        }
        else {
            castHit = Physics2D.BoxCast(this.transform.position, new Vector2(0.1f, 1f), 0f, transform.right, attackRange / 2f, enemyForMe);
        }
    }

    private void walk()
    {
        if (isFriend) { // Friend
            transform.Translate(transform.right * speed / 10f);
        }
        else { // Enemy
            transform.Translate(-transform.right * speed / 10f);
        }
    }

    private void attack()
    {
        audioSource.PlayOneShot(attackse);

        //anim.SetBool("isAttack", true);
        isAttacking = true;
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
        if (damageTime <= animetime && damageTime + Time.fixedDeltaTime > animetime) {
            if (isFriend)
                attacker = Instantiate(bullet, this.transform.position + new Vector3( attackRange / 2f, vertical_challenge,0), Quaternion.Euler(0.0f, 0.0f, 0.0f), this.transform);
            else
                attacker = Instantiate(bullet, this.transform.position - new Vector3( attackRange / 2f, vertical_challenge,0), Quaternion.Euler(0.0f, 0.0f, 0.0f), this.transform);
            
            isAttacking = false;
            animetime = 0f;
        }
    }
}