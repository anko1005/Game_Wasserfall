using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameOverScreen : MonoBehaviour
{
    public Text Timescore;

    public void Setup(int score)
    {
        gameObject.setActive(true)
        Timescore.text = score.ToString() + "Timescore";

    }

    public void ReplayButton()
    {
        SceneManager.loadScene("Level1");
    }

    public void QuitButton()
    {
        SceneManager.loadScene("MainMenu");
    }
}
