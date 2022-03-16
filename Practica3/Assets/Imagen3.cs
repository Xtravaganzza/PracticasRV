using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Imagen3 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Escena3()
    {
        SceneManager.LoadScene("Practica3parte2");
    }

    public void CargarEscena3(string escena3)
    {
        SceneManager.LoadScene(escena3);
    }
}
