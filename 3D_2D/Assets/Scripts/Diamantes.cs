using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Diamantes : MonoBehaviour
{
    private TPEscenas tele;
    string nombreEscena;
    Scene m_escena;

   void Start()
    {
        m_escena = SceneManager.GetActiveScene();
        nombreEscena = m_escena.name;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            switch (nombreEscena)
            {
                case "Azul":
                    SceneManager.LoadScene("Roja");
                    break;
                case "Roja":
                    SceneManager.LoadScene("Morado");
                    break;

            }
            
        }
    }
}
