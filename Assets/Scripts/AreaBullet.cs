using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AreaBullet : MonoBehaviour
{
    CharaSimple charaController;
    Transform parent;
    private float second = 0.1f;
    private float time;
    public int power;
    public float attackRange;
    void Start()
    {
        charaController = GetComponentInParent<CharaSimple>();
        parent = GetComponentInParent<Transform>();

        if (charaController != null) {
            power = charaController.power;
            attackRange = charaController.attackRange;
            if (!charaController.isFriend)
                attackRange = -attackRange;
        }
        else {
            power = 0;
            attackRange = 0;
        }
        this.transform.position = new Vector3(parent.position.x + attackRange, parent.position.y, parent.position.z);
    }

    void FixedUpdate()
    {
        time += Time.deltaTime;
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
        }
    }
}
