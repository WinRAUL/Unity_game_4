using System.Collections;  
using System.Collections.Generic;  
using UnityEngine;  
  
public class MotionScript : MonoBehaviour  
{  

    bool onGround;
    int clickCount=0;
    public void Jump(){
        if(onGround)
            GetComponent<Rigidbody>().AddForce(Vector3.up * 6, ForceMode.VelocityChange);
        onGround = false;
    }
    public void RightWalk(){
        if(onGround)
            GetComponent<Rigidbody>().AddForce(Vector3.right * 3, ForceMode.VelocityChange);
        else if(clickCount<=2){
            GetComponent<Rigidbody>().AddForce(Vector3.right * 4, ForceMode.VelocityChange);
            clickCount++;
        }
    }
    public void LeftWalk(){
        if(onGround)
            GetComponent<Rigidbody>().AddForce(Vector3.left * 3, ForceMode.VelocityChange);
        else if(clickCount<=2){
            GetComponent<Rigidbody>().AddForce(Vector3.left * 4, ForceMode.VelocityChange);
            clickCount++;
        }
    }
////////////////////////////////////////////////////////////////////////////////   
    void Update()  
    {
        if(Input.GetKeyDown(KeyCode.Space))
            Jump();
        if(Input.GetKeyDown(KeyCode.RightArrow))
            RightWalk();
        if(Input.GetKeyDown(KeyCode.LeftArrow))
            LeftWalk(); 
    }
////////////////////////////////////////////////////////////////////////////////
    void OnCollisionEnter(Collision targetobject){
        if(targetobject.gameObject.name == "grass"){                //Ground Check
                clickCount=0;
                onGround = true;
            }
    }

}