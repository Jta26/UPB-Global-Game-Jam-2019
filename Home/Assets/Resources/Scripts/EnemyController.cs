//Credit: Unity Tutorials

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : PhysicsObject
{
    public float maxSpeed = 8;
    public float jumpTakeOffSpeed = 10;
    public bool playerToLeft;
    public float playerX;

    void Awake () 
    {
        playerX = transform.position.x;
        playerToLeft = GameObject.FindGameObjectWithTag ("Player").transform.position.x < transform.position.x;
    }

    protected override void ComputeVelocity()
    {
        Vector2 move = playerToLeft ? Vector2.left : Vector2.right;

        if (grounded) {
            velocity.y = jumpTakeOffSpeed;
        } else if (Input.GetButtonUp ("Jump")) 
        {
            if (velocity.y > 0) {
                velocity.y = velocity.y * 0.5f;
            }
        }

        targetVelocity = move * maxSpeed;
    }
}
