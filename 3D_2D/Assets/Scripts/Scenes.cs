using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Scenes : MonoBehaviour
{
    int dim = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        if (Input.GetKeyDown(KeyCode.B))
        {
            
            tprojo();
            
        }
        else if (Input.GetKeyDown(KeyCode.N)) { 
           
            tpmorado();
            
        }
        else if(Input.GetKeyDown(KeyCode.M))
        {
          
            tpazul();
            
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
