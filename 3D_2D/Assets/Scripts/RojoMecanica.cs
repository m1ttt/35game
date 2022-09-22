using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RojoMecanica : MonoBehaviour
{
    public float Speed;
    public float Jump_Force;
    private bool velocidad=true;
    private Rigidbody2D Rigidbody2D;
    private float Horizontal;
    private Animator Animator;
    private bool Grounded;
    private bool Vertical;

    // Start is called before the first frame update
    void Start()
    {

        Rigidbody2D = GetComponent<Rigidbody2D>();
        Animator = GetComponent<Animator>();

    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.A))
        {
            Horizontal = Input.GetAxisRaw("Horizontal");
        }
        else
        {
            
        }
        


        if (Horizontal < 0.0f) transform.localScale = new Vector3(-1.0f, 1.0f, 1.0f);
        else if (Horizontal > 0.0f) transform.localScale = new Vector3(1.0f, 1.0f, 1.0f);


        Animator.SetBool("corriendo", Horizontal != 0.0f);


        if (Physics2D.Raycast(transform.position, Vector3.down, 0.2f))
        {
            Grounded = true;
            Animator.SetBool("enSuelo", true);

        }
        else
        {
            Grounded = false;
            Animator.SetBool("enSuelo", false);
        }


        // Salto
        if (Input.GetKeyDown(KeyCode.W) && Grounded)
        {

            Jump();
        }

        if (Input.GetKeyDown(KeyCode.LeftShift))
        {

            velocidad = true;

        }
        else if (Input.GetKeyDown(KeyCode.LeftControl))
        {
            velocidad = false;
            }

    }
    private void Jump()
    {
        Rigidbody2D.AddForce(Vector2.up * Jump_Force);

    }

    private void FixedUpdate()
    {
        if (velocidad)
        {
            Rigidbody2D.velocity = new Vector2(Horizontal * 2, Rigidbody2D.velocity.y);

        }
        else
        {

            Rigidbody2D.velocity = new Vector2(Horizontal, Rigidbody2D.velocity.y);
        }
    
    }
}