using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UI_PausenMenu: MonoBehaviour
{
    public static bool GameIsPaused = false;

    public GameObject UI_Pause;

    
    
    public void Resume ()
    {
        UI_Pause.SetActive(false);
        Time.timeScale = 1f;
        GameIsPaused = false;
    }
    void Pause ()
    {
        UI_Pause.SetActive(true);
        Time.timeScale = 0f;
        GameIsPaused = true;
    }

    public void LoadMenu ()
    {
        SceneManager.LoadScene("UI_MainMenu");
    }


    
}
