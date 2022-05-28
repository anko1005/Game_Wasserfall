using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    private int obstaclePos;
    public GameObject prefab;

    public Transform[] SpawnPositions;
    // Start is called before the first frame update
    void Start()
    {
        obstaclePos = 1;
        InvokeRepeating("Spawn", 1,5);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void Spawn()
    {
        obstaclePos = Random.Range(0, SpawnPositions.Length);
        Instantiate(prefab, SpawnPositions[obstaclePos].position, Quaternion.identity);  
    }
}

