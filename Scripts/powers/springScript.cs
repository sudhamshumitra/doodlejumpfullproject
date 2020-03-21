using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class springScript : MonoBehaviour
{
    void OnCollisionEnter2D(Collision2D collision)
    {
        //Make character jump on hitting the platform
        if (collision.relativeVelocity.y <= 0f)
        {
            collision.rigidbody.AddForce(Vector2.up * 20, ForceMode2D.Impulse);
        }


    }

    //Destroy object when the screen moves up
    private void OnBecameInvisible()
    {
        Destroy(gameObject);
    }

}
