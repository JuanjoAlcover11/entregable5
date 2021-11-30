using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class SpawnManager : MonoBehaviour
{//Declaramos las siguientes variables: Un gameobject al que le asignaremos el obstaculo, la posicion donde queremos que aparezca el obstaculo, 
 //un tiempo que se corresponde a quando debe aparecer el primer obstaculo y otro que nos dice el intervalo de tiempo entre cada vez que spawnea el obstaculo
    public GameObject obstaclePrefab;
    public Vector3 spawnPos = new Vector3(0, 0, 30);
    private float startTime = 0.5f;
    private float repeatRate = 5f;

    //Hacemos que el obstaculo haga spawn en el tiempo que le hemos indicado
    void Start()
    {
        InvokeRepeating("SpawnObstacle", startTime, repeatRate);
    }

    //Hacemos que el obstaculo puede aparecer al,eatoriamente entre una determinada altura
   public void SpawnObstacle()
    {   
        //Hacemos que el obstaculo puede aparecer al,eatoriamente entre una determinada altura
        float randomY = Random.Range(-10, 10);
        //Indicamos la posicion del obstaculo en la variable spawnPos y hacemos que haya 50 de distancia en el eje z entre cada obstaculo
        spawnPos = new Vector3(0, randomY, spawnPos.z + 50);
        //Instanciamos el prefab en una posicion y rotacion determinadas
        Instantiate(obstaclePrefab, spawnPos,
           obstaclePrefab.transform.rotation);

    }
}
