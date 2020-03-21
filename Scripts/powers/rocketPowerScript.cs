using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rocketPowerScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Destroy(gameObject);
            collision.rigidbody.AddForce(transform.up * 20, ForceMode2D.Impulse);
        }
    }

    
}
