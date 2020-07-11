using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody2D rigidbody;
    public float speed;
    public float jumpForce;
  
    private void Update() {
        if(Input.GetKeyDown(KeyCode.UpArrow))
        {
            jump();
        }
    }
    void FixedUpdate()
    {
        move();
        if(rigidbody.velocity.y<0)
        {
            rigidbody.gravityScale=5;
        }
        else
        {
            rigidbody.gravityScale=1f;
        }
        
    }

    void move()
    {
        float xDirectionValue = InputManager.Instance.getXDirection();
        rigidbody.velocity = new Vector2(xDirectionValue * speed, rigidbody.velocity.y);
    }

    void jump()
    { 
        rigidbody.velocity = new Vector2(rigidbody.velocity.x,0);
        rigidbody.velocity+=Vector2.up*jumpForce; 
    }
}
