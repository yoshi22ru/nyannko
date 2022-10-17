using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    CharaSimple charaController;
    private int speed = 10;
    private float second;
    private float time;
    public int power;
    public float attackRange;
    public bool isFriend;
    void Start()
    {
        charaController = GetComponentInParent<CharaSimple>();
        if (charaController != null) {
            power = charaController.power;
            attackRange = charaController.attackRange;
        }
        else {
            power = 0;
            attackRange = 0;
        }

        second = attackRange / speed;
        if (!(isFriend = charaController.isFriend))
            speed = -speed;
    }

    void FixedUpdate()
    {
        time += Time.fixedDeltaTime;

        this.transform.Translate(speed * Time.fixedDeltaTime, 0.0f, 0.0f);
        if (time >= second) {
            Destroy(this.gameObject);
        }
    }
}
