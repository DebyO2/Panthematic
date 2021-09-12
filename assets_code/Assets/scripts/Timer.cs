using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class Timer : MonoBehaviour
{
    public int timeStart;
    public float currentTime;
    public Text clock;
    public Text score;
    public float currentScore;
    public float delay = 1f;
    private float timer;

    public Text Highscore;
    public Text longestTime;

    void Start()
    {
        currentScore = 0;
        currentTime = 0;
        clock.text = "00:00:00";
        score.text = $"Score : {currentScore}";
        longestTime.text = "Time : 00:00:00";
    }

    // Update is called once per frame
    void Update()
    {
        currentTime = currentTime + Time.deltaTime;
        TimeSpan time = TimeSpan.FromSeconds(currentTime);
        clock.text = time.Hours.ToString().PadLeft(2,'0') + ":" + time.Minutes.ToString().PadLeft(2,'0') + ":" + time.Seconds.ToString().PadLeft(2,'0');

        timer += Time.deltaTime;
        
        if(timer >= delay)
        {
            timer = 0;
            score.text = $"Score : {currentScore++}";
        }

        Highscore.text = $"Score : {currentScore}";
        longestTime.text = $"Time : {clock.text}";
    }
}
