using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine;

public class GameOverScreen : MonoBehaviour
{
    /*public Text Timescore;

    public void Setup(int score)
    {
        gameObject.setActive(true)
        Timescore.text = score.ToString() + "Timescore";

    }*/

    public void NewGame()
    {
        SceneManager.LoadScene("Level_1");/*SceneManager.GetActiveScene().buildIndex + 1); falls wir mehr szenen haben*/
    }

    public void BackMainMenu()
    {
        SceneManager.LoadScene("UI_MainMenu");
    }
}
