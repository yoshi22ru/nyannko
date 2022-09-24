using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Enemy : MonoBehaviour
{
    public static Enemy instance;

    AudioSource audioSource;

    private Animator anim = null;

    public bool isDead = false;

    public void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (ìGÇÃHPä«óù.instance.isDead)
            anim.Play("Dead");
    }




}

