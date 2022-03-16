using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Imagen2 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Escena2()
    {
        SceneManager.LoadScene("Practica3parte2c");
    }

    public void CargarEscena2(string escena2)
    {
        SceneManager.LoadScene(escena2);
    }
}
