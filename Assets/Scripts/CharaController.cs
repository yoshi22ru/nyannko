using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharaController : MonoBehaviour
{
    [Header("Enemy or Friend")]
    public bool isFriend;
    [Header("Propaty")]
    public int HP = 10;
    [SerializeField] private int power = 1;
    [SerializeField] private float speed = 1.0f;
    [SerializeField] private float attackRange;
    [Header("animation")]
    private Animator anim;
    [SerializeField] private float attackAnimationLength;
    [Header("This↓ mean the length of Time")]
    [Header("which from starting animation to taking attack")]
    [SerializeField] private float damageTime;
    private float animetime;

    public LayerMask enemyForMe;
    private bool castHit;
    private RaycastHit Hit;

    void FixedUpdate()
    {
        walk();

        if (castHit)
            attack();
    }

    private void walk()
    {
        if (isFriend) {
            this.transform.rotation = Quaternion.Euler(new Vector3(0.0f, 0.0f, 0.0f));
            if (!(castHit = Physics.Raycast(this.transform.position, transform.right, attackRange, enemyForMe)))
                transform.Translate(transform.right * speed);
        }
        else {
            this.transform.rotation = Quaternion.Euler(new Vector3(0.0f, 180.0f, 0.0f));
            if (!(castHit = Physics.Raycast(this.transform.position, -transform.right, attackRange, enemyForMe)))
                transform.Translate(transform.right * speed);
        }
    }

    private void attack()
    {
        anim.SetBool("isAttack", true);

        animetime += Time.deltaTime;

        if (Mathf.Approximately(animetime, damageTime)) {
            Physics.Raycast(this.transform.position, -transform.right, out Hit, attackRange, enemyForMe);
        }
    }
}
