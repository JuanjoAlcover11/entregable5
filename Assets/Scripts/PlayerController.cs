using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{//Declaramos variables de tipo de float para declarar la velocidad a la que avanza el Player, la velocidad a la que gira, las teclas necesarias para hacer que gire y el punto en el que se termina el juego
    private float speed = 10f;
    private float turnSpeed = 40f;
    private float verticalInput;
    private float zMax = 450f;
    // Start is called before the first frame update

   void Update()
    {   
        //Le asignamos al verticalInput las flechas de arriba y abajo
        verticalInput = Input.GetAxis("Vertical");
        //Hacemos que el avion avance
        transform.Translate(Vector3.forward * speed * Time.deltaTime);
        //Hacemos que el avion gire al pulsar las teclas correspondientes
        transform.Rotate(Vector3.left, turnSpeed * Time.deltaTime * verticalInput);
        //Hacemos que se termine la partida si el jugador llega al limite que le hemos puesto
        if (transform.position.z > zMax)
        {
            Time.timeScale = 0;
            Debug.Log("THE END");

        }
    }
}
