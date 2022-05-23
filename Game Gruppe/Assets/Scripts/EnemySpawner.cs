using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    private int obstaclePos;
    public GameObject prefab;
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
        
        if (obstaclePos == 1)
        {
            Instantiate(prefab, new Vector3(3.7f, 6.78f, -56.82145f), Quaternion.identity);
        }
        if (obstaclePos == 2)
        {
            Instantiate(prefab, new Vector3(6.5f, 6.78f, -56.82145f), Quaternion.identity);
        }
        if (obstaclePos == 3)
        {
            Instantiate(prefab, new Vector3(0.91f, 6.78f, -56.82145f), Quaternion.identity);
        }
        obstaclePos = Random.Range(1, 4);
        
    }
}

