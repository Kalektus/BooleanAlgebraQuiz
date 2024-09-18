using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class BackButtonHandler : MonoBehaviour
{
    public GameObject pausemenu;

    // Start is called before the first frame update
    void Start()
    {
        pausemenu.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape)){
            pausemenu.SetActive(true);
        }
    }
    public void GoToMainMenu(){
        QuestionGenerate.displayingQuestion = false;
        QuestionDisplay.pleaseUpdate = false;
        SceneManager.LoadScene("MainMenu");
    }
    public void Cancel(){
        pausemenu.SetActive(false);
}
}