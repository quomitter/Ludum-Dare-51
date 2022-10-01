using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreKeeper : MonoBehaviour
{
    private InTheAir inTheAir; 
    public TMP_Text scoreText;
    public TMP_Text highScoreText;


    // Start is called before the first frame update
    void Start()
    {
        inTheAir = FindObjectOfType<InTheAir>();
    }

    // Update is called once per frame
    void Update()
    {
        scoreText.text = "Score:" + System.Convert.ToString(inTheAir.jumpCounter);

        if(inTheAir.jumpCounter < 0){
            //gameover
        }
    }
}
