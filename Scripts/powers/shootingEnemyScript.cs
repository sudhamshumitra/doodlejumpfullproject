using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class shootingEnemyScript : MonoBehaviour
{
    public GameObject bullet;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("shootBullet", 1, 2);
    }

    private void shootBullet()
    {
        Instantiate(bullet, transform.position, Quaternion.identity);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Destroy(gameObject);
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);            
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
