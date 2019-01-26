using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Animation_Controller : MonoBehaviour
{
    Animator anim;
    SpriteRenderer renderer;

    public RuntimeAnimatorController walk;
    public RuntimeAnimatorController Idle;
    // Start is called before the first frame update
    void Start()
    {
        anim = this.GetComponent<Animator>();
        renderer = this.GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.D)) {
            
            anim.runtimeAnimatorController = walk;
            renderer.flipX = false;
        }
        if (Input.GetKeyDown(KeyCode.A)) {
            anim.runtimeAnimatorController = walk;
            renderer.flipX = true;
        }
        if (Input.GetKeyUp(KeyCode.D) || Input.GetKeyUp(KeyCode.A)) {
            anim.runtimeAnimatorController = Idle;
        }

        

        
    }
}
