using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Diamantes : MonoBehaviour
{
    private TPEscenas tele;
    string nombreEscena;
    Scene m_escena;
    // Start is called before the first frame update
    void Start()
    {
        tele = GetComponent<TPEscenas>();
        m_escena = SceneManager.GetActiveScene();
        nombreEscena = m_escena.name;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Gemas")
        {
            switch (nombreEscena)
            {
                case "Azul":
                    tele.tpazul();
                    break;
                case "Morado":
                    tele.tpmorado();
                    break;
                case "Roja":
                    tele.tprojo();
                    break;
            }
        }
    }
}
