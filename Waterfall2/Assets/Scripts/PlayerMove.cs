using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class PlayerMove : MonoBehaviour
{
    //private int row;
    public CharacterController controller;
    Rigidbody rb;
    public GameObject swipeManager;

    Vector3 startPos;
    public Vector3 playerPos = new Vector3(-1.06f, 1.05f,14.45f);
    
    void Start()
    {
        //row = 0;
        startPos = playerPos;
    }

    // Update is called once per frame
    /*void Update()
    {
        
        MoveLeftRight();
    }*/

    

    void MoveLeftRight()
    {
        if (SwipeManager.swipeLeft||Input.GetKeyDown("left"))
        {            
            playerPos += new Vector3(2.2f, 0f, 0f);
           
            /*if (new Vector)
            {
                controller.Move(new Vector3(2.2f, 0,0));
                row++;                               
            }*/
        }
        if (SwipeManager.swipeRight||Input.GetKeyDown("right"))
        {
            playerPos += new Vector3(-2.2f, 0f, 0f);

            /*if (row > -2)
            {
                //controller.Move(new Vector3(-2.2f,0,0));
                //row--;
                playerPos += new Vector3(-2.2f, 0f, 0f);
                
            }*/
            /*if (_inputHorizontal != 0)
            {
                _rb.velocity = _currentVelocity;
            }
            else
            {
                _currentVelocity = new Vector3(0f, 0f);
                _rb.velocity = _currentVelocity;
            }*/
        }
    }

    private void FixedUpdate()
    {
        MoveLeftRight();
        MovePlayer();
    }

    void MovePlayer()
    {
        controller.Move(
            Vector3.Lerp(
                transform.position, 
                startPos + playerPos, 
                Time.fixedDeltaTime * 5f));
    }

    public void ObstacleHit()
    {
        print("obstacle");
        //controller.Move(new Vector3(0f, 0f, -1f));
        playerPos -= new Vector3(0f, 0f, -1f);

        if(playerPos.z < -5f)
        {
            SceneManager.LoadScene("UI_GameOver");
            //Playermanager.gameOver = true;
        }
        

    }
    

    
}
