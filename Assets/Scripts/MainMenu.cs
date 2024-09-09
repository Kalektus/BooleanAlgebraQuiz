using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
public AudioSource CorrectFX;
public AudioSource InCorrectFX;
  public void PlayGame(){
        CorrectFX.Play();
        StartCoroutine(PlayPressed());
  }
IEnumerator PlayPressed(){
yield return new WaitForSeconds(0.4f);
  SceneManager.LoadSceneAsync(1);
}
public void QuitGame(){
        Application.Quit();
}
public void menusoundyes(){
    CorrectFX.Play();
}
public void menusoundno(){
    InCorrectFX.Play();
}
}
