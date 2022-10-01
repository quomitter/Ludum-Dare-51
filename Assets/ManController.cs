using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ManController : MonoBehaviour
{
    public Animator manAnim;
    public bool isJumping;  
    public AudioSource audioSource;
    public AudioClip jumpSound;

    // Start is called before the first frame update
    void Start()
    {
        manAnim = GetComponent<Animator>(); 
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetButtonDown("Jump")){
            manAnim.SetBool("isJumping", true);
            isJumping = true; 
            AudioSource.PlayClipAtPoint(jumpSound,new Vector3(-7f,3f,0f));
        }
        if(Input.GetButtonUp("Jump")){
            manAnim.SetBool("isJumping", false);
            isJumping = false; 
        }

        if(Input.touchCount > 0){
            Touch touch = Input.GetTouch(0);
            if(touch.phase == TouchPhase.Began){
                manAnim.SetBool("isJumping", true);
                isJumping = true; 
                AudioSource.PlayClipAtPoint(jumpSound,new Vector3(-7f,3f,0f));
            }
            if(touch.phase == TouchPhase.Ended){
                manAnim.SetBool("isJumping", false);
                isJumping = false; 
            }
        }

    }
}
