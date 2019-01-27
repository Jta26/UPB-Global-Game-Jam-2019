using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Animation_Controller : MonoBehaviour
{
    Animator anim;
    SpriteRenderer renderer;

    public RuntimeAnimatorController walk;
    public RuntimeAnimatorController Idle;
    public Sprite jumpSprite;
    // Start is called before the first frame update
    void Start()
    {
        anim = this.GetComponent<Animator>();
        renderer = this.GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown ("Jump")) {
            anim.runtimeAnimatorController = null;
            renderer.sprite = jumpSprite;
        }
        else if (Input.GetAxis("Horizontal") != 0) {
            anim.runtimeAnimatorController = walk;
            renderer.flipX = Input.GetAxis("Horizontal") <= 0;
        }
        else {
            anim.runtimeAnimatorController = Idle;
        }
    }
}
