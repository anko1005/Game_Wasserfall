using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Score_Time : MonoBehaviour

{
    public static Score_Time instance;
    public Text scoreValueText;
    public float scoreValue = 0f;
    public float pointIncreacesPerSecond = 1f;
    //int score = 0;
    //public Text highscoretext;
    //public float highscore;

    float lastHighscore;

    private void Awake ()
    {
        instance = this;
        if (PlayerPrefs.HasKey("Highscore"))
            lastHighscore = PlayerPrefs.GetFloat("Highscore");
        else
            lastHighscore = 0f;
    }

    private void OnDisable()
    {
        if(scoreValue > lastHighscore)
        {
            PlayerPrefs.SetFloat("Highscore", scoreValue);
        }
    }

    private void FixedUpdate()
    {
        scoreValueText.text = ((int)scoreValue).ToString() + ": Score";
        scoreValue += pointIncreacesPerSecond * Time.fixedDeltaTime;
    }

    public void AddPoints ()
    {
        scoreValue += 50;
        scoreValueText.text = ((int)scoreValue).ToString() + ": Score";
    }
}