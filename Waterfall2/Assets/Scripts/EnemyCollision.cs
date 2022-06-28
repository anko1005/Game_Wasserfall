using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyCollision : MonoBehaviour 
{
    bool notHit = true;

    private void OnCollisionEnter(Collision collision)
    {
        if (notHit == true)
        {
            if (collision.gameObject.CompareTag("Player"))
            {
                notHit = false;
            }
        }
        
    }
}
