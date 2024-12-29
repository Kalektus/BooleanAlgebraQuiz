using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Stats : MonoBehaviour
{
    public GameObject DisplayHiScore; // objekt za prikazivanje najboljeg rezultata
    // Start is called before the first frame update
    void Start()
    {
        AnswerButtons.HiScore = PlayerPrefs.GetInt("HiScorePlayer");
        DisplayHiScore.GetComponent<Text>().text = "HiScore: " + AnswerButtons.HiScore;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
