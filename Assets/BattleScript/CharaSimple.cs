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

    public LayerMask enemyForMe;
    private bool isAttacking = false;
    private bool castHit;
    private RaycastHit Hit;

    // damage
    Bullet E_bullet;
    public GameObject text;
    DamageText dam_text;

    void FixedUpdate()
    {
        if (!isAttacking) {// if I`m not attacking
            checkRange();   // check enemy in attack range
            if (castHit) {// if enemy is in attack range
                Debug.Log("Encounted");
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

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Bullet"))
        {
            E_bullet = other.GetComponent<Bullet>();
            if (E_bullet.isFriend != isFriend) {
                HP -= E_bullet.power;
                //dam_text = Instantiate(text, this.transform.position, Quaternion.Euler(0f, 0f, 0f)).GetComponent<DamageText>();
                //dam_text.damage = E_bullet.power;
                Destroy(other.gameObject);
                if (HP <= 0) {
                    Destroy(this.gameObject);
                }
            }
        }
    }

    private void checkRange()
    {
        if (isFriend) {
            castHit = Physics2D.BoxCast(this.transform.position, new Vector2(0.1f, 1f), 0f, transform.right, attackRange, enemyForMe);
        }
        else {
            castHit = Physics2D.BoxCast(this.transform.position, new Vector2(0.1f, 1f), 0f, transform.right, attackRange, enemyForMe);
        }
    }

    private void walk()
    {
        if (isFriend) { // Friend
            this.transform.rotation = Quaternion.Euler(new Vector3(0.0f, 0.0f, 0.0f));
            transform.Translate(transform.right * speed / 10f);
        }
        else { // Enemy
            this.transform.rotation = Quaternion.Euler(new Vector3(0.0f, 180.0f, 0.0f));
            transform.Translate(-transform.right * speed / 10f);
        }
    }

    private void attack()
    {
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
            Instantiate(bullet, this.transform.position, Quaternion.Euler(0.0f, 0.0f, 0.0f), this.transform);
        }
    }
}