using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public static float timeRemaining = 10;
    public static bool timeIsRunning = true;
    public GameObject timerText;
    // Start is called before the first frame update
    void Start()
    {
       timeIsRunning = true; 
    }

    // Update is called once per frame
    void Update()
    {
        if(timeIsRunning)
        {
            if (timeRemaining > 0)
            {
                timeRemaining -= Time.deltaTime;
                DisplayTime(timeRemaining);
            }
            else{
                timeRemaining = 0;
                timeIsRunning = false;
            }
        }
        
    }

    void DisplayTime (float timeToDisplay)
    {
        timeToDisplay +=1;
        float seconds = Mathf.FloorToInt ( timeToDisplay % 60);
        timerText.GetComponent<Text>().text = string.Format ("Time left: {0:00}", seconds);
    }

}