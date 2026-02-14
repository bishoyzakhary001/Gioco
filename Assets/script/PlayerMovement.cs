using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    Playermovement controls;
    float direction = 0;

    public float speed;

    public Rigidbody2D playerrb;

    private Animator animator;
    private void Awake()
    {
        controls = new Playermovement();
        controls.Enable();

        controls.movement.move.performed += ctx =>
        {
            direction = ctx.ReadValue<float>();
        };
        animator = GetComponent<Animator>();
    }
   
    // Update is called once per frame
    void Update()
    {
        playerrb.linearVelocity = new Vector2(direction * speed * Time.deltaTime, playerrb.linearVelocity.y);

        if (direction> 0f)
        {
            animator.SetBool("camminata", true);
        }
        else if (direction < 0f)
        {
            animator.SetBool("camminata", true);
        }
        else
        {
            animator.SetBool("camminata", false);
        }
        if (direction < -0.01f) transform.localScale = new Vector3(-1, 1, 1);
        if (direction > 0.01f) transform.localScale = new Vector3(1, 1, 1);
    }
}
