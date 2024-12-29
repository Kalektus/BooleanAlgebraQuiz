using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AnswerButtons : MonoBehaviour
{
    public GameObject answerAbackBlue; // objekt za aktiviranje plavog bojanja tipke - wait
    public GameObject answerAbackGreen; // objekt za aktiviranje zelenog bojanja tipke - tocan odgovor
    public GameObject answerAbackRed; // objekt za aktiviranje crvenog bojanja tipke - krivi odgovor
    public GameObject answerBbackBlue; 
    public GameObject answerBbackGreen; 
    public GameObject answerBbackRed; 
    public GameObject answerCbackBlue; 
    public GameObject answerCbackGreen; 
    public GameObject answerCbackRed; 
    public GameObject answerDbackBlue; 
    public GameObject answerDbackGreen;
    public GameObject answerDbackRed; 
    public GameObject answerA; // varijabla za tipku
    public GameObject answerB;
    public GameObject answerC;
    public GameObject answerD;
    public AudioSource CorrectFX; // varijabla za zvuk tocnog odgovora
    public AudioSource InCorrectFX; // varijabla za zvuk krivog odgovora
    public GameObject CurScore; // objekt trenutnog rezultata
    public int scoreValue; // varijabla spremanja rezultata(bodova)
    public GameObject ButtonA; // objekt za manipulaciju tipkom
    public GameObject ButtonB; // objekt za manipulaciju tipkom
    public GameObject ButtonC; // objekt za manipulaciju tipkom
    public GameObject ButtonD; // objekt za manipulaciju tipkom
    public GameObject ScreenQuestion;  // objekt za pokazivanje teksta za pitanje
    public static int HiScore; // varijabla za najbolji rezultat koji prikazujemo
    public GameObject DisplayHiScore; // objekt za prikazivanje najboljeg rezultata
    public GameObject QuestionImage; // objekt za sliku pitanja
    public GameObject losermenu; // pop menu na krivi odg ili timeout


    void Start(){
       
    }

    void Update(){
        CurScore.GetComponent<Text>().text = "Score: " + scoreValue;
        if(losermenu.activeSelf){
        }else{
            timerEnd();
        }
    }

    public void AnswerA(){
        if (QuestionGenerate.actualAnswer == "A"){
            answerAbackGreen.SetActive(true);
            answerAbackBlue.SetActive(false);
            CorrectFX.Play();
            if(QuestionImage.activeSelf){
                scoreValue = scoreValue + 2;
            }else{
               scoreValue = scoreValue + 1; 
            }
            Stats.correctA = Stats.correctA + 1;
            PlayerPrefs.SetInt("CorrectAnswers", Stats.correctA);
            PlayerPrefs.Save();
        }
        else{
            answerAbackRed.SetActive(true);
            answerAbackBlue.SetActive(false);
            InCorrectFX.Play();
            losermenu.SetActive(true);
            Timer.timeIsRunning = false;
        }
        answerA.GetComponent<Button>().enabled = false;    // gasimo mogucnost stiskanja tipke nakon odgovora
        answerB.GetComponent<Button>().enabled = false;
        answerC.GetComponent<Button>().enabled = false;
        answerD.GetComponent<Button>().enabled = false;
        if (QuestionGenerate.actualAnswer == "A"){   
        StartCoroutine(NextQuestion());
        }
    
    }

    public void AnswerB(){
        if (QuestionGenerate.actualAnswer == "B"){
            answerBbackGreen.SetActive(true);
            answerBbackBlue.SetActive(false);
            CorrectFX.Play();
            if(QuestionImage.activeSelf){
                scoreValue = scoreValue + 2;
            }else{
               scoreValue = scoreValue + 1; 
            }
            Stats.correctA = Stats.correctA + 1;
            PlayerPrefs.SetInt("CorrectAnswers", Stats.correctA);
            PlayerPrefs.Save();
        }
        else{
        answerBbackRed.SetActive(true);
        answerBbackBlue.SetActive(false);
        InCorrectFX.Play();
        losermenu.SetActive(true);
    }
    answerA.GetComponent<Button>().enabled = false;    // gasimo mogucnost stiskanja tipke nakon odgovora
    answerB.GetComponent<Button>().enabled = false;
    answerC.GetComponent<Button>().enabled = false;
    answerD.GetComponent<Button>().enabled = false;
    if (QuestionGenerate.actualAnswer == "B"){   
        StartCoroutine(NextQuestion());
        }   
    }

   public void AnswerC(){ 
        if (QuestionGenerate.actualAnswer == "C"){
            answerCbackGreen.SetActive(true);
            answerCbackBlue.SetActive(false);
            CorrectFX.Play();
            if(QuestionImage.activeSelf){
                scoreValue = scoreValue + 2;
            }else{
               scoreValue = scoreValue + 1; 
            }
        Stats.correctA = Stats.correctA + 1;
        PlayerPrefs.SetInt("CorrectAnswers", Stats.correctA);
        PlayerPrefs.Save();
        }
        else{
        answerCbackRed.SetActive(true);
        answerCbackBlue.SetActive(false);
        InCorrectFX.Play();
        losermenu.SetActive(true);
    }
    answerA.GetComponent<Button>().enabled = false;    // gasimo mogucnost stiskanja tipke nakon odgovora
    answerB.GetComponent<Button>().enabled = false;
    answerC.GetComponent<Button>().enabled = false;
    answerD.GetComponent<Button>().enabled = false; 
    if (QuestionGenerate.actualAnswer == "C"){   
        StartCoroutine(NextQuestion());
        }   
    } 

    public void AnswerD(){
        if (QuestionGenerate.actualAnswer == "D"){
            answerDbackGreen.SetActive(true);
            answerDbackBlue.SetActive(false);
            CorrectFX.Play();
            if(QuestionImage.activeSelf){
                scoreValue = scoreValue + 2;
            }else{
               scoreValue = scoreValue + 1; 
            }
        Stats.correctA = Stats.correctA + 1;
        PlayerPrefs.SetInt("CorrectAnswers", Stats.correctA);
        PlayerPrefs.Save();
        }
        else{
        answerDbackRed.SetActive(true);
        answerDbackBlue.SetActive(false);
        InCorrectFX.Play();
        losermenu.SetActive(true);
    }
    answerA.GetComponent<Button>().enabled = false;    // gasimo mogucnost stiskanja tipke nakon odgovora
    answerB.GetComponent<Button>().enabled = false;
    answerC.GetComponent<Button>().enabled = false;
    answerD.GetComponent<Button>().enabled = false; 
    if (QuestionGenerate.actualAnswer == "D"){   
        StartCoroutine(NextQuestion());
    }   
    }


    void timerEnd(){
        if(!Timer.timeIsRunning){
            losermenu.SetActive(true);
            InCorrectFX.Play();
            answerA.GetComponent<Button>().enabled = false;    // gasimo mogucnost stiskanja tipke nakon odgovora
            answerB.GetComponent<Button>().enabled = false;
            answerC.GetComponent<Button>().enabled = false;
            answerD.GetComponent<Button>().enabled = false;
            Timer.timeIsRunning = true;
        }
    }

    IEnumerator NextQuestion()
    {
        if (HiScore < scoreValue){
            PlayerPrefs.SetInt("HiScorePlayer", scoreValue);
            HiScore = scoreValue;
        }
        yield return new WaitForSeconds(2);

        answerAbackGreen.SetActive(false);
        answerBbackGreen.SetActive(false);
        answerCbackGreen.SetActive(false);
        answerDbackGreen.SetActive(false);
        answerAbackRed.SetActive(false);
        answerBbackRed.SetActive(false);
        answerCbackRed.SetActive(false);
        answerDbackRed.SetActive(false);
        answerAbackBlue.SetActive(true);
        answerBbackBlue.SetActive(true);
        answerCbackBlue.SetActive(true);
        answerDbackBlue.SetActive(true);
        ScreenQuestion.SetActive(false);
        ButtonA.SetActive(false);
        ButtonB.SetActive(false);
        ButtonC.SetActive(false);
        ButtonD.SetActive(false);
        QuestionImage.SetActive(false);
        QuestionGenerate.displayingQuestion = false;  // govori drugoj skripti da pokaze drugo pitanje
        Timer.timeRemaining = 15;
        Timer.timeIsRunning = true;
    }

}

