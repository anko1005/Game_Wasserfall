using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine;

public class UI_GameOverScreen : MonoBehaviour
{
    /*public Text Timescore;

    public void Setup(int score)
    {
        gameObject.setActive(true)
        Timescore.text = score.ToString() + "Timescore";

    }*/

    //Restart Game: wird das gleiche Level nochmal geladen.
    public void NewGame()
    {
        SceneManager.LoadScene("Level_1_12.07");/*SceneManager.GetActiveScene().buildIndex + 1); falls wir mehr szenen haben*/
        Time.timeScale = 1f;
    }

    //EXIT: Zurück zum Hauptmenü wo man neu anfangen kann. 
    public void BackMainMenu()
    {
        SceneManager.LoadScene("UI_MainMenu");
    }
}
