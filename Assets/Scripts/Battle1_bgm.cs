using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Battle1_bgm : MonoBehaviour
{
    AudioSource audioSource;
   
    // Start is called before the first frame update
    void Start()
    {
        audioSource =this.GetComponent<AudioSource>();
        audioSource.Play();
    }

    // Update is called once per frame
    void Update()
    {
        if (������HP�Ǘ�.Instance.isDead || �G��HP�Ǘ�.Instance.isDead)
            audioSource.Stop();
    }
  
}
