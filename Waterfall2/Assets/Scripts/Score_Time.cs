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
    int score = 0;


    private void Awake ()
    {
        instance = this;
    }
    private void FixedUpdate()
    {
        scoreValueText.text = ((int)scoreValue).ToString() + ": Score";
        scoreValue += pointIncreacesPerSecond * Time.fixedDeltaTime;
    }

    public void AddPoints ()
    {
        score += 1000;
        scoreValueText.text = ((int)scoreValue).ToString() + ": Score";
    }
}