using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Stats : MonoBehaviour
{
    public GameObject DisplayHiScore; // objekt za prikazivanje najboljeg rezultata
    public GameObject DisplaycorrectA; // objekt za prikazivanje najboljeg rezultata
    public static int correctA;
    // Start is called before the first frame update
    void Start()
    {
        AnswerButtons.HiScore = PlayerPrefs.GetInt("HiScorePlayer");
        DisplayHiScore.GetComponent<Text>().text = "HiScore: " + AnswerButtons.HiScore;
        correctA = PlayerPrefs.GetInt("CorrectAnswers");
        DisplaycorrectA.GetComponent<Text>().text = "Correct Answers : " + correctA;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
