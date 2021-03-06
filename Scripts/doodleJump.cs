﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class doodleJump : MonoBehaviour
{

    private Rigidbody2D rb;
    private BoxCollider2D bc;
    private Vector3 stageDimensions;
    private Vector3 tilt;
    float inputAxis = 0f;
    public float speed = 12f;

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        bc = GetComponent<BoxCollider2D>();
        stageDimensions = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, 0));

}

// Start is called before the first frame update
void Start()
    {
    }

    private void FixedUpdate()
    {
        //movement based on mobile tilt
        Vector2 velocity = rb.velocity;
        velocity.x = inputAxis;
        rb.velocity = velocity;
       
    }

    //Game over if character goes outside screen
    private void OnBecameInvisible()
    {
        Destroy(gameObject);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);

    }


    // based on mobile tilt change position and velocity
    void Update()
    {
        inputAxis = Input.acceleration.x * speed ;
        Vector3 position = transform.position;
        Vector3 velocity = rb.velocity;
        
        //To ensure character comes back to screen when moved out of screen
        if (position.x > stageDimensions.x){
            position.x = -stageDimensions.x;
            transform.position = position;

        } else if (position.x < -stageDimensions.x){
            position.x = stageDimensions.x;
            transform.position = position;
        }
    }
}
