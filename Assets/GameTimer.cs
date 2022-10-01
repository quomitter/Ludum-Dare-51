using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameTimer : MonoBehaviour
{
    public Animator animRopeGuy;
    public Sprite[] gameNumbers; 
    public SpriteRenderer spriteRenderer;
    public AudioSource audioSource; 
    public AudioClip timerReset; 

    public float gameTimer;
    public int gameTimerWorker; 
    public float speedMultiplyer;

    // Start is called before the first frame update
    void Start()
    {
        speedMultiplyer = 1; 
        gameTimer = 10.999f; 
        audioSource = GetComponent<AudioSource>(); 
    }

    // Update is called once per frame
    void Update()
    {
        gameTimer -= Time.deltaTime;
        if(gameTimer < 0){
            gameTimer = 10.999f;
            AudioSource.PlayClipAtPoint(timerReset,new Vector3(-7f,3f,0f));
            speedMultiplyer = speedMultiplyer + 0.2f; 
            animRopeGuy.SetFloat("Speed", speedMultiplyer); 
        }
             
        gameTimerWorker = Mathf.RoundToInt(gameTimer);
       

        switch(gameTimerWorker){
            case 0: spriteRenderer.sprite = gameNumbers[0]; break; 
            case 1: spriteRenderer.sprite = gameNumbers[1]; break; 
            case 2: spriteRenderer.sprite = gameNumbers[2]; break; 
            case 3: spriteRenderer.sprite = gameNumbers[3]; break; 
            case 4: spriteRenderer.sprite = gameNumbers[4]; break; 
            case 5: spriteRenderer.sprite = gameNumbers[5]; break; 
            case 6: spriteRenderer.sprite = gameNumbers[6]; break; 
            case 7: spriteRenderer.sprite = gameNumbers[7]; break; 
            case 8: spriteRenderer.sprite = gameNumbers[8]; break; 
            case 9: spriteRenderer.sprite = gameNumbers[9]; break; 
            case 10: spriteRenderer.sprite = gameNumbers[10]; break;
        }


    }
}
