using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MecanicaGravedad : MonoBehaviour
{

    enum DireccionGravedad { Arriba, Izquierd, Abajo, Derecha};
    DireccionGravedad m_DireccionGravedad;
    // Start is called before the first frame update
    void Start()
    {
        m_DireccionGravedad = DireccionGravedad.Abajo;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            switch (m_DireccionGravedad){
                case DireccionGravedad.Arriba:
                    Physics2D.gravity = new Vector2(0, 9.8f);
                    if (Input.GetKeyDown(KeyCode.Space))
                    {

                    }
                    break;
            }
        }
    }
}
