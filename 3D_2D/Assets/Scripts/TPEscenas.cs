using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TPEscenas : MonoBehaviour
{
    public int escena = 0;
    // Start is called before the first frame update
    void Start()
    {
        S
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.B)&&SceneManager.GetActiveScene!="Lol")
        {
            if (escena != 3)
            {
                tprojo();
                escena = 3;
            }
            
          

        }
        else if (Input.GetKeyDown(KeyCode.N)) {
            if (escena != 2)
            {
                tpmorado();
                escena = 2;
            }



        }
        else if(Input.GetKeyDown(KeyCode.M))
        {


            if (escena != 1)
            {
                tpazul();
                escena = 1;
            }


        }
    }
    public void tprojo()
    {
        SceneManager.LoadScene("Roja"); 
        

    }
    public void tpazul()
    {
            SceneManager.LoadScene("Azul");
    }
    public void tpmorado()
    {
        SceneManager.LoadScene("SampleScene");        
    }
}
