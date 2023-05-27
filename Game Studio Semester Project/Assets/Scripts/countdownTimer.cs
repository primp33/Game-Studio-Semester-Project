using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class countdownTimer : MonoBehaviour
{
    public float timeRemaining = 3f * 60;

    public bool timeIsRunning = true;

    public Text timeText;

    void Start()
    {
        timeIsRunning = true;

    }

    void Update()
    {
        if (timeIsRunning)
        {
            if (timeRemaining >= 0)
            {
                timeRemaining -= Time.deltaTime;
                DisplayTime(timeRemaining);
            }
        }
    }

    void DisplayTime (float timeToDisplay)
    {
        timeToDisplay -= 1;
        float minutes = Mathf.FloorToInt(timeToDisplay / 60);
        float seconds = Mathf.FloorToInt(timeToDisplay % 60);

        timeText.text = string.Format("(00.00):(1.00)",minutes, seconds);
    }
}
