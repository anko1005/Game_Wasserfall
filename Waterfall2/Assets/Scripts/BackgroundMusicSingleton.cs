using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundMusicSingleton : MonoBehaviour
{
    #region Singleton
    private static BackgroundMusicSingleton instance;
    public static BackgroundMusicSingleton Instance
    {
        get
        {
            if (instance == null)
            {
                instance = FindObjectOfType<BackgroundMusicSingleton>();
                if (instance = null)
                {
                    GameObject GO = new GameObject();
                    GO.name = "BackgroundMusic";
                    instance = GO.AddComponent<BackgroundMusicSingleton>();
                    DontDestroyOnLoad(GO);
                }
            }
            return instance;
        }
    }

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }
    #endregion
}