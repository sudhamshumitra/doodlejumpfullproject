using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class simplePlatform : MonoBehaviour
{
    public int forceHeight = 10;
    public bool shouldDestroy = false;
   
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
 
    }

    //Destroy platform when not screen moves up
    private void OnBecameInvisible()
    {
        Destroy(gameObject);
    }

    void OnCollisionEnter2D (Collision2D collision)
    {
        //Make character jump on hitting the platform
        

        if (collision.gameObject.tag == "Player" && collision.relativeVelocity.y <= 0f)
        {
           collision.rigidbody.AddForce(Vector2.up * forceHeight, ForceMode2D.Impulse);
           if (shouldDestroy)
           {
               Destroy(gameObject);
           }
        }
        
        
    }
}
