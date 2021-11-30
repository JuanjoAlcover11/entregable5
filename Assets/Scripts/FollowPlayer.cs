using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{   //Declaramos las siguientes variables: Una variable de tipo GameObject que se corresponde a nuestro Player y una variable Vector3 para indicar la distancia a la que queremos la camara
    public GameObject Player;
    private Vector3 offset = new Vector3(90, 0, 0);

    // Utilizamos la variable offset para transformar la posicion de la camara desde el principio hasta el final
    private void Update()
    {
        transform.position = Player.transform.position + offset;
    }
}
