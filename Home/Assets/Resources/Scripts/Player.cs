using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : PhysicsObject {

    public GameObject gameObjectPlayer;
    public float maxSpeed = 8;
    public float jumpTakeOffSpeed = 10;

    public float spriteIndex;
    
//    private SpriteRenderer spriteRenderer;
//    private Animator animator;

    // Use this for initialization
    void Start () 
    {
        fitCollider();
        Debug.Log("start called");
//        spriteRenderer = GetComponent<SpriteRenderer> (); 
//        animator = GetComponent<Animator> ();
    }
    protected override void ComputeVelocity()
    {
        Vector2 move = Vector2.zero;

        move.x = Input.GetAxis ("Horizontal");

        if (Input.GetButtonDown ("Jump") && grounded) {
            velocity.y = jumpTakeOffSpeed;
        } else if (Input.GetButtonUp ("Jump")) 
        {
            if (velocity.y > 0) {
                velocity.y = velocity.y * 0.5f;
            }
        }

//       bool flipSprite = (spriteRenderer.flipX ? (move.x > 0.01f) : (move.x < 0.01f));
//        if (flipSprite) 
//        {
//            spriteRenderer.flipX = !spriteRenderer.flipX;
//        }

//        animator.SetBool ("grounded", grounded);
//        animator.SetFloat ("velocityX", Mathf.Abs (velocity.x) / maxSpeed);

        targetVelocity = move * maxSpeed;
    }
    //Loads the sprites, Sets Player to random sprite.
    public void SetPlayerSprite(Sprite houseSprite) {
        SpriteRenderer spritePlayer = gameObjectPlayer.GetComponentInChildren<SpriteRenderer>();
        spritePlayer.sprite = houseSprite;
    }
    private void fitCollider() {
        // GameObject body = GameObject.FindGameObjectWithTag("body");
        // GameObject limbs = GameObject.FindGameObjectWithTag("limbs");
        // BoxCollider2D bodyCol = body.GetComponent<BoxCollider2D>();
        // BoxCollider2D limbsCol = limbs.GetComponent<BoxCollider2D>();
        // SpriteRenderer bodyrndr = body.GetComponent<SpriteRenderer>();
        // SpriteRenderer limbsrndr = limbs.GetComponent<SpriteRenderer>();
        // Vector2 v = bodyrndr.bounds.size;
        // bodyCol.size = v;
        // // BoxCollider2D box = this.GetComponentInChildren<BoxCollider2D>();
        // // box.size = v;
        // Debug.Log("set collider");
    }

    private void OnCollisionEnter2D(Collision2D col) {
    }
}