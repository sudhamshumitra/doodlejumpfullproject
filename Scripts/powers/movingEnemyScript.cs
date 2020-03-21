using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class movingEnemyScript : MonoBehaviour
{

    Rigidbody2D rb;
    BoxCollider2D bc;
    private Vector3 stageDimensions;
    private int direction = 1;
    

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        bc = GetComponent<BoxCollider2D>();
        stageDimensions = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, 0));
        
    }

    // Update is called once per frame
    void Update()
    {
        if ((bc.bounds.center.x + bc.bounds.extents.x) >= stageDimensions.x)
        {
            direction = -1;
        }
        else if ((bc.bounds.center.x - bc.bounds.extents.x) <= -stageDimensions.x)
        {
            direction = 1;
        }
        rb.velocity = transform.right * 2 * direction;        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Destroy(gameObject);
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
    }
}
