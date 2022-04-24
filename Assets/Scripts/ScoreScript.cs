using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ScoreScript : MonoBehaviour
{
    public Text scoreText;
    public static int points=0;           //coin counter                 
    void Update()
    {
        scoreText.text = "Score : " + points.ToString();        
    }

    public void AddScore(){
        points++;
    }
}
