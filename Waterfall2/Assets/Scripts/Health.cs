using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Health : MonoBehaviour
{
    bool notHit = true;

    private void OnCollisionEnter(Collision collision)
    {
        if (notHit == true)
        {
            if (collision.gameObject.CompareTag("Player")) // Tag muss in Unity gesetzt werden!
            {
                notHit = false;
                collision.gameObject.GetComponent<PlayerMove>().Healing();
                Destroy(this.gameObject);
            }
        }

    }
}
