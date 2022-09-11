using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextMove : MonoBehaviour
{
    Animator animator;

    // スタート時に呼ばれる
    void Start()
    {
        this.animator = GetComponent<Animator>();
        animator.SetTrigger("on");
        animator.SetTrigger("off");
       
    }
    

}
