using System.Collections;
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

    private void OnBecameInvisible()
    {
        Destroy(gameObject);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);

    }


    // Update is called once per frame
    void Update()
    {
        inputAxis = Input.acceleration.x * speed ;
        Vector3 position = transform.position;
        Vector3 velocity = rb.velocity;
      //  Debug.Log("yvalue_" + position.y);

        //For debugging easily on laptop, have to remove this
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            rb.AddForce(Vector2.right * 2, ForceMode2D.Impulse);
        }
        else if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            rb.AddForce(Vector2.left * 2, ForceMode2D.Impulse);
        }


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
