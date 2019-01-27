using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_Animation_Controller : MonoBehaviour
{

    public Animator anim;
    private SpriteRenderer renderer;
    public RuntimeAnimatorController relativeController;
    // Start is called before the first frame update
    void Start()
    {
        anim = this.GetComponent<Animator>();
        renderer = this.GetComponent<SpriteRenderer>();
        anim.runtimeAnimatorController = relativeController;
        
    }

    // Update is called once per frame
    void Update()
    {
    }
}
