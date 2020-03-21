using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rocketPowerScript : MonoBehaviour
{
  
    //give character upward force if the character collects rocket
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Destroy(gameObject);
            collision.rigidbody.AddForce(transform.up * 20, ForceMode2D.Impulse);
        }
    }

    
}
