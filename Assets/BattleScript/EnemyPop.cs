using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyPop : MonoBehaviour
{
    [Header("Enemy Set")]
    [SerializeField] private int EnemyNum;
    [SerializeField] private GameObject[] Enemy;
    [SerializeField] private float[] Frequency;
    [SerializeField] private Transform catsle;
    private int maxhp;

    private float time;
    bool hit;
    bool hp_downer;
    [Header("Case Efect")]
    [SerializeField] private bool dont_use_case_one = false;
    [SerializeField] private float argment_one = 1f;
    [SerializeField] private bool dont_use_case_two = false;
    [SerializeField] private float argment_two = 1f;
    void Start()
    {
        maxhp = Enemy_HPManager.Instance.敵のhp;
        time = 1;
    }
    void FixedUpdate()
    {
        time += Time.fixedDeltaTime;

        if (hit = (Physics2D.BoxCast(this.transform.position, new Vector2(0.1f, 1f), 0f, -transform.right, (this.transform.position.x - catsle.position.x) / 2f, 128) && !dont_use_case_one)) {
            time += Time.fixedDeltaTime * argment_one;
        }
        if (hp_downer = (Enemy_HPManager.Instance.敵のhp <= maxhp / 2 && !dont_use_case_two)) {
            time += Time.fixedDeltaTime * argment_two;
        }

        GenerateMonster();
    }

    private void GenerateMonster()
    {
        float num = 1;
        if (hit)
            num += argment_one;
        if (hp_downer)
            num += argment_two;
        for (int i = 0; i < EnemyNum; i++) {
            if (time % Frequency[i] <= Time.fixedDeltaTime * num)
            {
                Instantiate(Enemy[i], this.transform.position,Quaternion.Euler(0, 0, 0));
            }
        }
    }
}
