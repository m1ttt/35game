using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TPEscenas : MonoBehaviour
{
    Scene m_escena;
    string nombreEscena;
    public GameObject Rapido;
    public GameObject Morado;
    public GameObject Lento;


    // Start is called before the first frame update
    void Start()
    {
        m_escena = SceneManager.GetActiveScene();
        nombreEscena = m_escena.name;

            }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.B)&&nombreEscena!="Roja")
        {

            tprojo();
            

        }
        else if (Input.GetKeyDown(KeyCode.N) && nombreEscena != "Morado") {


            tpmorado();
            

        }
        else if(Input.GetKeyDown(KeyCode.M) && nombreEscena != "Azul")
        {

            tpazul();
            

        }
    }
    public void tprojo()
    {
        SceneManager.LoadScene("Roja");
        Instantiate(Rapido);

    }
    public void tpazul()
    {
            SceneManager.LoadScene("Azul");
        Instantiate(Lento);
    }
    public void tpmorado()
    {
        SceneManager.LoadScene("Morado");
        Instantiate(Morado);

    }
}
