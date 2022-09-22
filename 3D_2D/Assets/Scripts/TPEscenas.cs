using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TPEscenas : MonoBehaviour
{
    Scene m_escena;
    string nombreEscena;
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
        else if (Input.GetKeyDown(KeyCode.N) && nombreEscena != "SampleScene") {


            tpmorado();

        }
        else if(Input.GetKeyDown(KeyCode.M) && nombreEscena != "Azul")
        {

            tpazul();


        }
    }
    private void tprojo()
    {
        SceneManager.LoadScene("Roja"); 
        

    }
    private void tpazul()
    {
            SceneManager.LoadScene("Azul");
    }
    private void tpmorado()
    {
        SceneManager.LoadScene("SampleScene");        
    }
}
