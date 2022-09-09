using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyPop : MonoBehaviour
{
    [SerializeField] private Transform PopPos;
    [Header("Catsle Settings")]
    [SerializeField] float HP;
    [Header("Enemy Set")]
    [SerializeField] private int EnemyNum;
    [SerializeField] private GameObject[] Enemy;
    [SerializeField] private float[] Frequency;

    private float time;
    void Start()
    {
        time = 0;
    }
    void Update()
    {
        time += Time.deltaTime;

        GenerateMonster();
        if (HP <= 0) {
            GameClear();
        }
    }

    private void GenerateMonster()
    {
        for (int i = 0; i < EnemyNum; i++)
            if (Mathf.Approximately(time % Frequency[i], 0.0f))
            {
                Instantiate(Enemy[i], PopPos.position,Quaternion.identity);
            }
    }

    private void GameClear()
    {
        
    }
}
