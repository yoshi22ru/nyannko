using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyPop : MonoBehaviour
{
    [Header("Enemy Set")]
    [SerializeField] private int EnemyNum;
    [SerializeField] private GameObject[] Enemy;
    [SerializeField] private float[] Frequency;

    private float time;
    void Start()
    {
        time = 1;
    }
    void FixedUpdate()
    {
        time += Time.fixedDeltaTime;

        GenerateMonster();
    }

    private void GenerateMonster()
    {
        for (int i = 0; i < EnemyNum; i++) {
            if (time % Frequency[i] <= Time.fixedDeltaTime)
            {
                Instantiate(Enemy[i], this.transform.position,Quaternion.identity);
            }
        }
    }
}
