using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControladorCam : MonoBehaviour
{
    public GameObject jugador; //Referencia al jugador
    Vector3 distancia; //Relacion de la distancia entre camara jugador
    // Start is called before the first frame update
    void Start()
    {
        distancia = transform.position - jugador.transform.position;   //Ver la distancia
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = jugador.transform.position + distancia; //Sirve para seguir al jugador en caa update
    }
}
