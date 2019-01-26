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
        Debug.Log("start called");
        SetPlayerSprite();
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
    void SetPlayerSprite() {
        SpriteRenderer spritePlayer = gameObjectPlayer.GetComponent<SpriteRenderer>();
        object[] houseSprites = Resources.LoadAll("Sprites/houses", typeof (Sprite));
        for (int i = 0; i < houseSprites.Length; i++) {
            houseSprites[i] = (Sprite) houseSprites[i];
        }
        spritePlayer.sprite = (Sprite) houseSprites[Mathf.RoundToInt(Random.Range(0, houseSprites.Length))];
        
        
    }
    
}