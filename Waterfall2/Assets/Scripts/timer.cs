using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class timer : MonoBehaviour
{
    bool stopwatchActive = false;
    float currentTime;
    public Text currentTimeText;

    int score
    public Text scoreText;
    public float multiplier = 5;

    void Start()
    {
        currentTime = 0;
    }

    // Update is called once per frame
    void Update()
    {
       if(stopwatchActive == true)
        { 
            currentTime = currentTime + timer.deltaTime; 
        }
        score = Mathf.RoundtoInt(currentTime * multiplier);
        scoreText.text = score.ToString();

        TimeSpan time = TimeSpan.FromSeconds(currentTime);
        currentTimeText.text = time.ToString(@"mm\:ss\:fff");
                               //time.Minutes.ToString() + ":" + time.Seconds.ToString() + ":" + time.Milliseconds.ToString();
    }

    public void StartStopwatch()
    {
        stopwatchActive = true;
    }

    public void StopStopwatch()
    {
        stopwatchActive = false;
    }
}
