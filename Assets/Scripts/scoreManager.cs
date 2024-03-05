using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class scoreManager : MonoBehaviour
    
{
        public Text scoreText;
        public static int ScoreCount;
   
    void Start()
    {
        
    }

 
    void Update()
    {
        scoreText.text = "score :" + Mathf.Round(ScoreCount);
    }
}
