using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Playermanager : MonoBehaviour
{
    public static bool gameOver;
    public GameObject gameOverPanel;

    void Start()
    {
        gameOver = false;
        Time.timeScale = 1;
        
    }

    // Update is called once per frame
    void Update()
    {
        if (gameOver)
        {
            Time.timeScale = 0;
            gameOverPanel.SetActive(true);
        }

        /*für GameOverPanel - TilesManager einbinden? Bei Tile "3"? activate GameOverPanel?*/
            
        
    }
}
