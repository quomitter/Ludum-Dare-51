using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ManController : MonoBehaviour
{
    public Animator manAnim;
    public bool isJumping;  

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
        }
        if(Input.GetButtonUp("Jump")){
            manAnim.SetBool("isJumping", false);
            isJumping = false; 
        }

    }
}
