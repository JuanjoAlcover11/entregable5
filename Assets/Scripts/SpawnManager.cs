using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class SpawnManager : MonoBehaviour
{
    public GameObject obstaclePrefab;
    public Vector3 spawnPos = new Vector3(0, 0, 30);
    private float startTime = 0.5f;
    private float repeatRate = 5f;

    void Start()
    {
        InvokeRepeating("SpawnObstacle", startTime, repeatRate);
    }

   public void SpawnObstacle()
    {
        float randomY = Random.Range(-10, 10);
        spawnPos = new Vector3(0, randomY, spawnPos.z + 50);
        Instantiate(obstaclePrefab, spawnPos,
           obstaclePrefab.transform.rotation);

    }
}
