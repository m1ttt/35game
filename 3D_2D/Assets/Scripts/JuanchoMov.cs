using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JuanchoMov : MonoBehaviour
{

    private Rigidbody2D Rigidbody2D;

    // Start is called before the first frame update
    void Start()
    {

        Rigidbody2D = GetComponent<Rigidbody2D>();
        
    }

    // Update is called once per frame
    void Update()
    {
        float horizontal = Input.GetAxisRaw("Horizontal");

    }
}
