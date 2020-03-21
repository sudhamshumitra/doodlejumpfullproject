using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class shootingEnemyScript : MonoBehaviour
{
    public GameObject bullet;

    //call shoot bullet at regular intervals so that the enemy can shoot bullet out
    void Start()
    {
        InvokeRepeating("shootBullet", 1, 2);
    }

    //Instantiate bullet object
    private void shootBullet()
    {
        Instantiate(bullet, transform.position, Quaternion.identity);
    }

    //game over if object collides
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Destroy(gameObject);
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);            
        }
    }

    
}
