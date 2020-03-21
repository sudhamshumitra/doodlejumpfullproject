using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class simplePlatform : MonoBehaviour
{
    public int forceHeight = 10;
    public bool shouldDestroy = false;
   
    
    //Destroy platform when screen moves up
    private void OnBecameInvisible()
    {
        Destroy(gameObject);
    }

    //Make character jump on hitting the platform
    void OnCollisionEnter2D (Collision2D collision)
    {
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
