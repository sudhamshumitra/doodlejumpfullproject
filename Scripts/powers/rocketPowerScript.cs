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

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Destroy(gameObject);
            collision.GetComponent<Rigidbody2D>().AddForce(transform.up * 15, ForceMode2D.Impulse);
        }
    }

    
}
