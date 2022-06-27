using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PlayerMove : MonoBehaviour
{
    private int row;
    public CharacterController controller;
    public GameObject swipeManager;
    
    // Start is called before the first frame update
    void Start()
    {
        row = 0;
    }

    // Update is called once per frame
    void Update()
    {
        MoveLeftRight();
    }

    void MoveLeftRight()
    {
        if (SwipeManager.swipeLeft||Input.GetKeyDown("left"))
        {
            if (row<2)
            {
                controller.Move(new Vector3(2.2f, 0,0));
                row++;
            }
        }
        if (SwipeManager.swipeRight||Input.GetKeyDown("right"))
        {
            if (row > -2)
            {
                controller.Move(new Vector3(-2.2f,0,0));
                row--;
            }
        }
    }
    on ControllerColliderHit(ControllerColliderHit hit)
    {
        if(hit.transform.tag == "Obstacle")
        {
            
            transform.position = transform.position + Vector3 (0,0, - 2.2f);
            //1 Schritt nach hinten versetzen
        }
    }
    //Playermanager.gameOver = true;

    
}
