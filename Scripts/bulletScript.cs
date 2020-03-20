using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bulletScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int randomNumberY = Random.Range(1, 6);
        int randomNumberX = Random.Range(-6, 6);
        GetComponent<Rigidbody2D>().velocity = new Vector2(randomNumberX, randomNumberY) * 3;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
