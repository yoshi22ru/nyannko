using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    CharaSimple charaController;
    public float destroyTime;
    private float time;
    public int power;
    public float attackRange;
    public bool isFriend;
    //public bool type;
    void Awake()
    {
        charaController = GetComponentInParent<CharaSimple>();
        power = charaController.power;
        isFriend = charaController.isFriend;

    }
    void Start()
    {
    }

    void FixedUpdate()
    {
        time += Time.fixedDeltaTime;
        if (time >= destroyTime) {
            Destroy(this.gameObject);
        }
    }
}
