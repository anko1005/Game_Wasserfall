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
            if (row<1)
            {
                controller.Move(new Vector3(2.5f, 0,0));
                row++;
            }
        }
        if (SwipeManager.swipeRight||Input.GetKeyDown("right"))
        {
            if (row > -1)
            {
                controller.Move(new Vector3(-2.5f,0,0));
                row--;
            }
        }
    }
    
}
