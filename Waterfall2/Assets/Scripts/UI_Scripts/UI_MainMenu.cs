using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UI_MainMenu : MonoBehaviour
{
    public static bool GameIsPaused = false;

    public void StartNewGame ()
    {
        SceneManager.LoadScene("Level_1_12.07");/*SceneManager.GetActiveScene().buildIndex + 1); falls wir mehr szenen haben*/
        // Time reset, hit, pos, row zurücksetzten
        Time.timeScale = 1f;
    }

    public void ExitGame()
    {
        Debug.Log("ExitGame");
        Application.Quit();
    }
}
