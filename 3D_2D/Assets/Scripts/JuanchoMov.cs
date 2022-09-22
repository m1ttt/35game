using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JuanchoMov : MonoBehaviour
{
    public float Speed;
    public float Jump_Force;
    
    private Rigidbody2D Rigidbody2D;
    private float Horizontal;
    private Animator Animator;
    private bool Grounded;

    // Start is called before the first frame update
    void Start()
    {

        Rigidbody2D = GetComponent<Rigidbody2D>();
        Animator = GetComponent<Animator>();
        
    }

    // Update is called once per frame
    void Update()
    {
      
     
        Horizontal = Input.GetAxisRaw("Horizontal");
        Animator.SetBool("corriendo", Horizontal != 0.0f);
        if (Physics2D.Raycast(transform.position, Vector3.down, 0.1f))
        {
            Grounded = true;
        }
        else Grounded = false;

        // Salto
        if (Input.GetKeyDown(KeyCode.W) && Grounded)
        {
            Jump();
        }
    }
    private void Jump()
    {
        Rigidbody2D.AddForce(Vector2.up*Jump_Force);
    }

    private void FixedUpdate()
    {
        Rigidbody2D.velocity = new Vector2(Horizontal, Rigidbody2D.velocity.y);
    }
}
