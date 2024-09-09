using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; // koristimo za manipulaciju UI elementima

public class QuestionDisplay : MonoBehaviour
{
public GameObject ScreenQuestion;  // objekt za pokazivanje teksta za pitanje
public GameObject answerA; // objekt za prikaz teksta na tipki
public GameObject answerB; // objekt za prikaz teksta na tipki
public GameObject answerC; // objekt za prikaz teksta na tipki
public GameObject answerD; // objekt za prikaz teksta na tipki
public static string newQuestion; // varijabla za prikaz novog pitanja
public static string newA; // varijabla za prikaz novog odgovora
public static string newB; // varijabla za prikaz novog odgovora
public static string newC; // varijabla za prikaz novog odgovora
public static string newD; // varijabla za prikaz novog odgovora
public static bool pleaseUpdate = false; // koristimo za update pitanja


void Update(){
if (pleaseUpdate == false){
pleaseUpdate  = true;
StartCoroutine(PushTextOnScreen()); // prikazi pitanje
}
}

IEnumerator PushTextOnScreen(){
yield return new WaitForSeconds(0.05f); // pricekaj kratko vrijeme prije prikazivanja pitanja
ScreenQuestion.GetComponent<Text>().text = newQuestion;  // ucitaj novo pitanje
answerA.GetComponent<Text>().text = newA; // ucitaj nov odgovor A
answerB.GetComponent<Text>().text = newB; // ucitaj nov odgovor B
answerC.GetComponent<Text>().text = newC; // ucitaj nov odgovor C
answerD.GetComponent<Text>().text = newD; // ucitaj nov odgovor D
}

}
