using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{   
    //public ScoreScript score;
    public void PlayGame(){
        ScoreScript.points = 0;
        //score.ResetScore();
        SceneManager.LoadScene("Lv1");
        Debug.Log("pressed and processed!");
    }

    public void QuitGame(){
        Application.Quit();
    }
}
