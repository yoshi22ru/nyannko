using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextMove : MonoBehaviour
{
    Animator animator;

    // �X�^�[�g���ɌĂ΂��
    void Start()
    {
        this.animator = GetComponent<Animator>();
        animator.SetTrigger("on");
        animator.SetTrigger("off");
       
    }
    

}
