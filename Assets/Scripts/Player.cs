using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Player : MonoBehaviour
{   
    bool onGround;
    public ScoreScript score;
    public AudioSource coinAudio;

////////////////////////////////////////////////
void OnCollisionEnter(Collision targetobject)
        {
            if(targetobject.gameObject.name == "ground Plane"){         //Restart When collided with plane
                SceneManager.LoadScene("GameOverScene");

            }
            if(targetobject.gameObject.name == "Flag"){                 //LEVEL UP
                SceneManager.LoadScene("Lv2");
            }
            if(targetobject.gameObject.name == "FinalFlag"){            //LEVEL UP
                SceneManager.LoadScene("FinalScene");
            }

            if(targetobject.gameObject.name == "grass"){                //Ground Check
                onGround = true;
            }

    }
////////////////////////////////////////////////
void OnTriggerEnter(Collider targetobject){
    if(targetobject.gameObject.tag == "coin"){
        coinAudio.Play();
        Destroy(targetobject.gameObject);
        score.AddScore();
    }
}
}
