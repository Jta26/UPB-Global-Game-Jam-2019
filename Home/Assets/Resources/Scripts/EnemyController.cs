//Credit: Unity Tutorials

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : PhysicsObject
{
    public float maxSpeed = 8;
    public float jumpTakeOffSpeed = 10;
    public bool playerToLeft, jumping;
    private SpriteRenderer spriteRenderer;

    void Awake () 
    {
        playerToLeft = GameObject.FindGameObjectWithTag ("playerHouse").transform.position.x < transform.position.x;
        spriteRenderer = GetComponent<SpriteRenderer> ();
    }

    protected override void ComputeVelocity()
    {
        Vector2 move = playerToLeft ? Vector2.left : Vector2.right;

        if (grounded && jumping) {
            velocity.y = jumpTakeOffSpeed;
        }

        bool flipSprite = (spriteRenderer.flipX ? (move.x < 0.01f) : (move.x > 0.01f));
        if (flipSprite) 
        {
            spriteRenderer.flipX = !spriteRenderer.flipX;
        }

        targetVelocity = move * maxSpeed;
    }
}
