using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Health : MonoBehaviour
{
    public Image healthBar;
    public float healthAmount = 3;

    /*private void Update()
    {
        if(healthAmount <= 0)
        {
            SceneManager.LoadScene("Gameover");
        }*/
    /*on ControllerColliderHit(ControllerColliderHit hit)
    {
        if (hit.transform.tag == "Obstacle")
        {
            healthAmount = healthAmount -  1;
        }
    }
    on ControllerColliderHit(ControllerColliderHit hit)
    {
        if (hit.transform.tag == "Health")
        {
            healthAmount = healthAmount + 1;
        }
    }*/
    /*if (collsiontag Obsticle) collsiononEnter?
     //baumstamm 1 leben weg
    {
        TakeDamage(1);

    }

    if(collsion)
    {
        Healing(1);
    }
}

public void TakeDamage(float Damage)
{
    healthAmount -= Damage;
    healthBar.fillAmount = healthAmount / 3;
}

public void Healing(float healPoints)
{
    healthAmount += healPoints;
    healthAmount = Mathf.Clamp(healthAmount, 0, 3);
}
}*/
}
