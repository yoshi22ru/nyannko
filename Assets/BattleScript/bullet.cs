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
        if (!charaController.isFriend)
            speed = -speed;
    }

    void FixedUpdate()
    {
        time += Time.deltaTime;

        this.transform.Translate(speed * Time.deltaTime, 0.0f, 0.0f);
        if (time >= second) {
            Destroy(this.gameObject);
        }
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("bullet"))
        {
            charaController = other.GetComponent<CharaSimple>();
            charaController.HP -= power;
            Destroy(this.gameObject);
        }
    }
}
