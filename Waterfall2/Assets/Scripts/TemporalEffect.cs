using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class TemporalEffect : MonoBehaviour
{
    public UnityEvent OnStart;
    public UnityEvent OnFinish;
    public float Runtime = 1f;

    float timer = 0f;

    private void OnEnable()
    {
        OnStart.Invoke();
    }

    private void Update()
    {
        timer += Time.deltaTime;
        if(timer >= Runtime)
        {
            timer = 0f;
            OnFinish.Invoke();
            gameObject.SetActive(false);
        }
    }
}
