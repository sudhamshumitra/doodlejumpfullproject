using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class getScore : MonoBehaviour
{
    
    Text finalScore;
    // Start is called before the first frame update
    void Start()
    {
        finalScore = GetComponent<Text>();

    }

    // Update is called once per frame
    void Update()
    {
        finalScore.text = "Final Score: " + scoreScript.score;
    }
}
