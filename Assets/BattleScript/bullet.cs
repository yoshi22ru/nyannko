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
        var localScale = this.transform.localScale;
        var parentLossyScale = this.transform.parent.lossyScale;

        this.transform.localScale = new Vector3(
        localScale.x / parentLossyScale.x,
        localScale.y / parentLossyScale.y,
        localScale.z / parentLossyScale.z
        );
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
