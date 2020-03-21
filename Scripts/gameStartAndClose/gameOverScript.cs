using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class gameOverScript : MonoBehaviour
{
    
    Text finalScore;
    
    void Start()
    {
        finalScore = GetComponent<Text>();

    }

    //show final score, haven't introduced leader board but can do that later using final score
    void Update()
    {
        finalScore.text = "Final Score: " + scoreScript.score;
    }
}
