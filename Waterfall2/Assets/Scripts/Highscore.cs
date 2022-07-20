using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Highscore : MonoBehaviour


{
    public Text HighscoreText;

    // Start is called before the first frame update
    void Start()
    {
        if (PlayerPrefs.HasKey("Highscore"))
            HighscoreText.text = "Best: " + ((int)PlayerPrefs.GetFloat("Highscore")).ToString();

    }

}