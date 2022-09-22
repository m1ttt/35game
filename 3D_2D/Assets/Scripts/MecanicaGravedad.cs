using System.Collections;
using System.Collections.Generic;
using UnityEngine;
    

public class MecanicaGravedad : MonoBehaviour
{
    private Rigidbody2D rb;
    public bool flag = false;
   
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        
    }

    // Update is called once per frame
    void Update()

    {
        
        if (Input.GetKeyDown(KeyCode.R)&&!flag)
        {
            StartCoroutine(temporizador());
        }
    }

    private IEnumerator temporizador()
    {
        JuanchoMov ayuda = gameObject.GetComponent<JuanchoMov>();
        rb.gravityScale *= -1;
        transform.rotation *= Quaternion.Euler(0, 0, 180f);
        ayuda.Raycaster();
        flag = true;
        yield return new WaitForSeconds(2);
        flag = false;
        
    }
}
