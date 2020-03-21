using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class infiniteLevel : MonoBehaviour
{
    public GameObject simplePlatform;
    public GameObject oneTouchPlatform;
    public GameObject noTouchPlatform;
    public GameObject coin;
    public GameObject rocket;
    public GameObject movingEnemy;
    public GameObject shootingEnemy;
    public GameObject spring;

    public int numberOfPlatforms = 400;
    public float minY = 0f;
    public float maxY = 0.4f;
    public float widthX = 2f;
    public float widthY = 0.5f;
    public float radius;

    public Collider2D[] colliders;

    // Start is called before the first frame update
    void Start()
    {
        Vector3 platformPosition = new Vector3();
        scoreScript.score = 0;       
        for (int i=0; i<numberOfPlatforms; i++)
        {
            int platformRandomness = Random.Range(0, 5);
            int superPowerRandomness = Random.Range(0, 5);
            int enemyRandomness = Random.Range(0, 8);

            platformPosition.y += widthY + Random.Range(minY, maxY);
            platformPosition.x = Random.Range(-widthX, widthX);


            if (i <= 50)
            {
                //Debug.Log(numberOfPlatforms);
                Instantiate(simplePlatform, platformPosition, Quaternion.identity);
            } else if (i > 50)
            {
                
                addPlatformAndEnemy(platformRandomness, enemyRandomness, platformPosition);
                if (platformRandomness <= 1)
                {
                    addPowers(superPowerRandomness, platformPosition);
                }

            }        
        }
    }

    void addPlatformAndEnemy(int platformRandomness, int enemyRandomness, Vector3 platformPosition)
    {
        switch (platformRandomness)
        {
            case 0:
                Instantiate(simplePlatform, platformPosition, Quaternion.identity);
                break;
            case 1:
                Instantiate(oneTouchPlatform, platformPosition, Quaternion.identity);
                break;
            case 2:
                if (enemyRandomness == 5)
                {
                    Instantiate(movingEnemy, platformPosition, Quaternion.identity);
                }
                else if (enemyRandomness == 7)
                {
                    Instantiate(shootingEnemy, platformPosition, Quaternion.identity);
                }
                break;
            case 4:
                Instantiate(noTouchPlatform, platformPosition, Quaternion.identity);
                break;
        }

        return;
    }


    void addPowers(int superPowerRandomness, Vector3 platformPosition)
    {
        Vector3 otherItemPosition = new Vector3(platformPosition.x - 0.2f, platformPosition.y + 0.3f, platformPosition.z);
        switch (superPowerRandomness)
        {
            case 0:
            case 1:
                Instantiate(coin, otherItemPosition, Quaternion.identity);
                break;
            case 2:
            case 3:
                Instantiate(spring, otherItemPosition, Quaternion.identity);
                break;
            case 4:
                Instantiate(rocket, otherItemPosition, Quaternion.identity);
                break;
        }

        return;
    }

    // Update is called once per frame
    void Update()
    {

    }
}
