using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DamageText : MonoBehaviour
{
    [SerializeField] private float speed = 0.01f;
    [SerializeField] private float deadtime = 2f;
    float time = 0;
    Text text;
    public int damage;
    void Start()
    {
        text.text = damage.ToString();
    }

    void FixedUpdate()
    {
        time += Time.fixedDeltaTime;
        transform.Translate(transform.up * speed);

        if (time >= deadtime)
            Destroy(this.gameObject);
    }
}
