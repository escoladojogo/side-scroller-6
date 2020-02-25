using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PossumController : MonoBehaviour
{
    public Rigidbody2D rigidBody;
    public SpriteRenderer spriteRenderer;

    float startX;
    bool movingLeft;

    private void Start()
    {
        startX = transform.position.x;
        movingLeft = true;
    }

    private void FixedUpdate()
    {
        if (movingLeft)
        {
            if (transform.position.x > startX - 8)
            {
                rigidBody.velocity = new Vector2(-5, rigidBody.velocity.y);
            }
            else
            {
                movingLeft = false;
                spriteRenderer.flipX = true;
            }
        }
        else
        {
            if (transform.position.x < startX + 8)
            {
                rigidBody.velocity = new Vector2(5, rigidBody.velocity.y);
            }
            else
            {
                movingLeft = true;
                spriteRenderer.flipX = false;
            }
        }
    }
}
