using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Respawn : MonoBehaviour
{

    private Vector2 respawn;
    public GameObject detectordeCaida;
    // Start is called before the first frame update
    void Start()
    {
        respawn = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        detectordeCaida.transform.position = new Vector2(transform.position.x, detectordeCaida.transform.position.y);

    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "DetectorDeCaida")
        {
            transform.position = respawn;
        }
    }
}
