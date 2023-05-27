using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class timer : MonoBehaviour
{
    public float timeValue = 90;

    public TextMeshProUGUI timeText;
    public GameObject lose;

    // Update is called once per frame
    void Start()
    {
        lose.SetActive(false);
    }
    void Update()
    {
        if (timeValue > 0)
        {
            timeValue -= Time.deltaTime;
        }
        else
        {
            timeValue = 0;
        }
        DisplayTime(timeValue);
    }

    void DisplayTime(float timeToDisplay)
    {
        if(timeToDisplay < 0)
        {
            timeToDisplay = 0;
            lose.SetActive(true);
            Time.timeScale = 0;
        }

        float minutes = Mathf.FloorToInt(timeToDisplay / 60);
        float seconds = Mathf.FloorToInt(timeToDisplay % 60);

        timeText.text = minutes + " : " + seconds;
            //string.Format("(0.00) : (1.00)", minutes, seconds);

    }
}
