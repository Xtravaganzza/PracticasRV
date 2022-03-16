using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Imagen1 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Escena1()
    {
        SceneManager.LoadScene("Practica3parte2b");
    }

    public void CargarEscena(string escena)
    {
        SceneManager.LoadScene(escena);
    }
}
