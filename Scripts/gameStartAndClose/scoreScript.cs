using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class scoreScript : MonoBehaviour
{
    public static int score = 0;
    Text scoreText;

   void Start()
    {
        scoreText = GetComponent<Text>();

    }

    // Update score text
    void Update()
    {
        scoreText.text = "Score: " + score;
    }
}
