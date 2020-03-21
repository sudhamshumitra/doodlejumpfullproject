using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

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

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Destroy(gameObject);
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
    }

}
