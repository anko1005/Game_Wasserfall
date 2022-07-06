using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class UI_Schwarzblende : MonoBehaviour

{

    public Image BlackscreenImage;

    Color StartColor = Color.black;
    Color Invisible;

    float progress = 0f;

    private void Start()
    {
        Invisible = StartColor;
        Invisible.a = 0f;

    }

    private void Update()
    {
        BlackscreenImage.color = Color.Lerp(StartColor, Invisible, progress);
        progress += Time.deltaTime;

        if(progress > 1f)
        {
            BlackscreenImage.color = Invisible;
            enabled = false;
        }

    }
}

