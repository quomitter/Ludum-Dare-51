using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InTheAir : MonoBehaviour
{
    public bool ropeOnGround;
    public int jumpCounter;
    public SpriteRenderer spriteRenderer; 
    public AudioSource audioSource;
    public AudioClip hitRopeSound; 
    
    private ManController manController; 

    // Start is called before the first frame update
    void Start()
    {
        manController = FindObjectOfType<ManController>();
        spriteRenderer = GetComponent<SpriteRenderer>();  
    }

    // Update is called once per frame
    void Update()
    {
        spriteRenderer.color = Color.white; 
        if(ropeOnGround && !manController.isJumping){
            //missed jump
            Debug.Log("missed jump");
            jumpCounter = jumpCounter - 1; 
            spriteRenderer.color = Color.red; 
            AudioSource.PlayClipAtPoint(hitRopeSound,new Vector3(-7f,3f,0f));
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
