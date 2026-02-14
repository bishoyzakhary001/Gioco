using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jump : MonoBehaviour
{
   // Rigidbody2D player;
    [SerializeField] float jumpforce;
    [SerializeField] float gravityScale = 5;
    [SerializeField] float fallGravityScale = 15;
    

    bool grounded;

    Playermovement controls;
   float direction = 0;

    //public float speed;

    public Rigidbody2D player;


    private void Awake()
    {
        controls = new Playermovement();
        controls.Enable();

        controls.movement.jump.performed += ctx =>
        {
            direction = ctx.ReadValue<float>();
        };
    }

   /* private void Update()
    {
        playerrb.velocity = new Vector2(playerrb.velocity.x, direction * speed * Time.deltaTime);
    }*/
    // Update is called once per frame
    void Update()
     {
        if (grounded && controls.movement.jump.triggered)
        {
            player.AddForce(Vector2.up * direction * jumpforce, ForceMode2D.Impulse);
        }

         if (player.linearVelocity.y > 0)
         {
             player.gravityScale = gravityScale;
         }
         else
         {
             player.gravityScale = fallGravityScale;
         }
     }
     private void OnCollisionEnter2D(Collision2D other)
     {
         if (other.gameObject.CompareTag("Ground"))
         {
             grounded = true;
         }
     }
     private void OnCollisionExit2D(Collision2D other)
     {
         if (other.gameObject.CompareTag("Ground"))
         {
             grounded = false;
         }
     }
}


