using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InTheAir : MonoBehaviour
{
    public bool ropeOnGround;
    public int jumpCounter;
    
    private ManController manController; 

    // Start is called before the first frame update
    void Start()
    {
        manController = FindObjectOfType<ManController>(); 
    }

    // Update is called once per frame
    void Update()
    {
        if(ropeOnGround && !manController.isJumping){
            //missed jump
            Debug.Log("missed jump");
            jumpCounter = jumpCounter - 1; 
        }
        if(ropeOnGround && manController.isJumping){
            //made jump
            Debug.Log("made jump");
            jumpCounter = jumpCounter + 10; 
        }
            if(!ropeOnGround && manController.isJumping){
            //made jump
            Debug.Log("made jump");
            jumpCounter = jumpCounter - 1; 
        }
    }
}
