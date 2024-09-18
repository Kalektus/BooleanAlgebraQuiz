using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class QuestionGenerate : MonoBehaviour
{
    public static string actualAnswer; // varijabla u koju spremamo koji je tocan odgovor
    public static bool displayingQuestion = false; // ako nije prikazano pitanje pokazi ga
    public int questionNumber; // varijabla koja pokazuje koje pitanje se prikazuje
    public GameObject ButtonA; // objekt za manipulaciju tipkom
    public GameObject ButtonB; // objekt za manipulaciju tipkom
    public GameObject ButtonC; // objekt za manipulaciju tipkom
    public GameObject ButtonD; // objekt za manipulaciju tipkom
    public GameObject ScreenQuestion;  // objekt za pokazivanje teksta za pitanje
    public GameObject answerA; // objekt za tipku
    public GameObject answerB;
    public GameObject answerC;
    public GameObject answerD;
    public GameObject QuestionImage; // objekt za sliku pitanja
    public Image pic; // manipulacija objektom slike za prikaz razlicitih slika za pitanja
    public Sprite Question3; // Sprite za 3.pitanje (sliku)
    public Sprite Question4; // Sprite za 4.pitanje (sliku)
    public Sprite Question5; // Sprite za 5.pitanje (sliku)
    public Sprite Question6; // Sprite za 6.pitanje (sliku)

    void Update()
    {
        if ( displayingQuestion == false) {
            questionNumber = Random.Range(1, 8);
            displayingQuestion = true;
            if (questionNumber == 1){
                QuestionDisplay.newQuestion = "Logical operator AND has output in 1 if:"; 
                QuestionDisplay.newA = "A. At least one input is 1";
                QuestionDisplay.newB = "B. Both inputs are 1";
                QuestionDisplay.newC = "C. If one input is 1 and another 0";
                QuestionDisplay.newD = "D. Output is always 1";
                ScreenQuestion.SetActive(true);
                ButtonA.SetActive(true);
                ButtonB.SetActive(true);
                ButtonC.SetActive(true);
                ButtonD.SetActive(true);
                answerA.GetComponent<Button>().enabled = true;    // palim mogucnost stiskanja tipke nakon odgovora
                answerB.GetComponent<Button>().enabled = true;
                answerC.GetComponent<Button>().enabled = true;
                answerD.GetComponent<Button>().enabled = true;
                actualAnswer = "B";
            }
            if (questionNumber == 2){
                QuestionDisplay.newQuestion = "Which of the following basic operations is shown with logical operator +?"; 
                QuestionDisplay.newA = "A. Negation (NOT)";
                QuestionDisplay.newB = "B. Conjunction (AND)";
                QuestionDisplay.newC = "C. Disjunction (OR)";
                QuestionDisplay.newD = "D. None of above";
                ScreenQuestion.SetActive(true);
                ButtonA.SetActive(true);
                ButtonB.SetActive(true);
                ButtonC.SetActive(true);
                ButtonD.SetActive(true);
                actualAnswer = "C";
                answerA.GetComponent<Button>().enabled = true;    // palim mogucnost stiskanja tipke nakon odgovora
                answerB.GetComponent<Button>().enabled = true;
                answerC.GetComponent<Button>().enabled = true;
                answerD.GetComponent<Button>().enabled = true;
            }
            if (questionNumber == 3){
                QuestionDisplay.newQuestion = "Calculate the values on the output if the input values are: A = 0, B = 0 i C = 1?"; 
                QuestionDisplay.newC = "A. 1";
                QuestionDisplay.newD = "B. 0";
                pic.sprite = Question3;
                QuestionImage.SetActive(true);
                ScreenQuestion.SetActive(true);
                ButtonC.SetActive(true);
                ButtonD.SetActive(true);
                actualAnswer = "D";
                answerC.GetComponent<Button>().enabled = true; // palim mogucnost stiskanja tipke nakon odgovora
                answerD.GetComponent<Button>().enabled = true;
            }
            if (questionNumber == 4){
                QuestionDisplay.newQuestion = "What function is implemented by the circuit shown?"; 
                QuestionDisplay.newA = "A. None of these";
                QuestionDisplay.newB = "B. x’ + y’ + z ";
                QuestionDisplay.newC = "C. x’y’ + z";
                QuestionDisplay.newD = "D. (x’ + y’)z";
                pic.sprite = Question4;
                QuestionImage.SetActive(true);
                ScreenQuestion.SetActive(true);
                ButtonA.SetActive(true);
                ButtonB.SetActive(true);
                ButtonC.SetActive(true);
                ButtonD.SetActive(true);
                actualAnswer = "A";
                answerA.GetComponent<Button>().enabled = true;    // palim mogucnost stiskanja tipke nakon odgovora
                answerB.GetComponent<Button>().enabled = true;
                answerC.GetComponent<Button>().enabled = true;
                answerD.GetComponent<Button>().enabled = true;
            }
            if (questionNumber == 5){
                QuestionDisplay.newQuestion = "What function is implemented by the circuit shown?"; 
                QuestionDisplay.newA = "A. x + y + z";
                QuestionDisplay.newB = "B. x + y + z’";
                QuestionDisplay.newC = "C. x’y’z";
                QuestionDisplay.newD = "D. x’ + y’ + z’";
                pic.sprite = Question5;
                QuestionImage.SetActive(true);
                ScreenQuestion.SetActive(true);
                ButtonA.SetActive(true);
                ButtonB.SetActive(true);
                ButtonC.SetActive(true);
                ButtonD.SetActive(true);
                actualAnswer = "B";
                answerA.GetComponent<Button>().enabled = true;    // palim mogucnost stiskanja tipke nakon odgovora
                answerB.GetComponent<Button>().enabled = true;
                answerC.GetComponent<Button>().enabled = true;
                answerD.GetComponent<Button>().enabled = true;
            }
            if (questionNumber == 6){
                QuestionDisplay.newQuestion = "What function is implemented by the circuit shown?"; 
                QuestionDisplay.newA = "A. AND";
                QuestionDisplay.newB = "B. OR";
                QuestionDisplay.newC = "C. NAND";
                QuestionDisplay.newD = "D. NOR";
                pic.sprite = Question6;
                QuestionImage.SetActive(true);
                ScreenQuestion.SetActive(true);
                ButtonA.SetActive(true);
                ButtonB.SetActive(true);
                ButtonC.SetActive(true);
                ButtonD.SetActive(true);
                actualAnswer = "C";
                answerA.GetComponent<Button>().enabled = true;    // palim mogucnost stiskanja tipke nakon odgovora
                answerB.GetComponent<Button>().enabled = true;
                answerC.GetComponent<Button>().enabled = true;
                answerD.GetComponent<Button>().enabled = true;
            }
            if (questionNumber == 7){
                QuestionDisplay.newQuestion = "Name the person who developed Boolean algebra."; 
                QuestionDisplay.newA = "A. George Boole";
                QuestionDisplay.newB = "B. Isaac Newton";
                QuestionDisplay.newC = "C. Neil deGrasse Tyson";
                QuestionDisplay.newD = "D. Bill Gates";
                ScreenQuestion.SetActive(true);
                ButtonA.SetActive(true);
                ButtonB.SetActive(true);
                ButtonC.SetActive(true);
                ButtonD.SetActive(true);
                answerA.GetComponent<Button>().enabled = true;    // palim mogucnost stiskanja tipke nakon odgovora
                answerB.GetComponent<Button>().enabled = true;
                answerC.GetComponent<Button>().enabled = true;
                answerD.GetComponent<Button>().enabled = true;
                actualAnswer = "A";
            }
            //Pitanja idu iznad ove linije
            QuestionDisplay.pleaseUpdate = false; // za prikazivanje sljedeceg pitanja
        }
    }
}
