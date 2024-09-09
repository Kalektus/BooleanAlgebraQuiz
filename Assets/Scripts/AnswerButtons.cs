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
    public int HiScore; // varijabla za najbolji rezultat koji prikazujemo
    public GameObject DisplayHiScore; // objekt za prikazivanje najboljeg rezultata
    public GameObject QuestionImage; // objekt za sliku pitanja


    void Start(){
        HiScore = PlayerPrefs.GetInt("HiScorePlayer");
        DisplayHiScore.GetComponent<Text>().text = "HiScore: " + HiScore;

    }

    void Update(){
        CurScore.GetComponent<Text>().text = "Score: " + scoreValue;
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
    }
        else{
            answerAbackRed.SetActive(true);
            answerAbackBlue.SetActive(false);
            InCorrectFX.Play();
            scoreValue = 0;
        }
        answerA.GetComponent<Button>().enabled = false;    // gasimo mogucnost stiskanja tipke nakon odgovora
        answerB.GetComponent<Button>().enabled = false;
        answerC.GetComponent<Button>().enabled = false;
        answerD.GetComponent<Button>().enabled = false;   
        StartCoroutine(NextQuestion());
    
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
        }
    
    
    else{
        answerBbackRed.SetActive(true);
        answerBbackBlue.SetActive(false);
        InCorrectFX.Play();
        scoreValue = 0;
    }
    answerA.GetComponent<Button>().enabled = false;    // gasimo mogucnost stiskanja tipke nakon odgovora
    answerB.GetComponent<Button>().enabled = false;
    answerC.GetComponent<Button>().enabled = false;
    answerD.GetComponent<Button>().enabled = false;
    StartCoroutine(NextQuestion());    
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
        }
    
    
    else{
        answerCbackRed.SetActive(true);
        answerCbackBlue.SetActive(false);
        InCorrectFX.Play();
        scoreValue = 0;
    }
    answerA.GetComponent<Button>().enabled = false;    // gasimo mogucnost stiskanja tipke nakon odgovora
    answerB.GetComponent<Button>().enabled = false;
    answerC.GetComponent<Button>().enabled = false;
    answerD.GetComponent<Button>().enabled = false; 
    StartCoroutine(NextQuestion()); 
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
        }
    
    
    else{
        answerDbackRed.SetActive(true);
        answerDbackBlue.SetActive(false);
        InCorrectFX.Play();
        scoreValue = 0;
    }
    answerA.GetComponent<Button>().enabled = false;    // gasimo mogucnost stiskanja tipke nakon odgovora
    answerB.GetComponent<Button>().enabled = false;
    answerC.GetComponent<Button>().enabled = false;
    answerD.GetComponent<Button>().enabled = false; 
    StartCoroutine(NextQuestion()); 
    }

    IEnumerator NextQuestion()
    {
        if (HiScore < scoreValue){
            PlayerPrefs.SetInt("HiScorePlayer", scoreValue);
            HiScore = scoreValue;
            DisplayHiScore.GetComponent<Text>().text = "HiScore: " + scoreValue;
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
    }

}

