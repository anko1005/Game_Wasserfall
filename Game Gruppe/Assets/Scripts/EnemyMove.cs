using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMove : MonoBehaviour
{
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        MoveForward();
        if (this.transform.position.z > 20)
            Destroy(gameObject);
    }

    void MoveForward()
    {
        transform.position = transform.position + new Vector3(0, 0, 10 * Time.deltaTime);
    }
}
