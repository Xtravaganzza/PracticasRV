using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Mover : MonoBehaviour
{
    public float vel = 0.35f; //Para la velocidad del personaje
    public Rigidbody mirigidbody; //Para poder utilisar el RigidBody
    public float vercital;
    public float horizontal;
    // Start is called before the first frame update
    void Start()
    {
        mirigidbody = GetComponent<Rigidbody>(); //Hacer una llamada al rigidBody
    }

    // Update is called once per frame
    void Update()
    {
        //Declarar variables para el movimiento mediante las teclas

        vercital = Input.GetAxis("Vertical");
        horizontal = Input.GetAxis("Horizontal");

        mirigidbody.AddForce(new Vector3(horizontal, 0, vercital) * vel); //Para el movimiento
    }
    void OnTrigerEnter(Collider otro)
    {
        if (otro.CompareTag("Start"))
        {
            //Aqui se inicializa el cronometro
            Debug.Log("has iniciado el laberinto");
        }
        if (otro.CompareTag("Finish"))
        {
            //Aqui se Finaliza el cronometro el cronometro
            Debug.Log("has terminado con éxito");
        }
    }
}
