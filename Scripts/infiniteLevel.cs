using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class infiniteLevel : MonoBehaviour
{
    //Gameobjects that can be instantiated when the game opens, can figure out a code later which will instantiate near the screen area, but for now everything gets instantiated at the first go
    public GameObject simplePlatform;
    public GameObject oneTouchPlatform;
    public GameObject noTouchPlatform;
    public GameObject coin;
    public GameObject rocket;
    public GameObject movingEnemy;
    public GameObject shootingEnemy;
    public GameObject spring;

    //Number of platforms in the game
    public int numberOfPlatforms = 400;

    //Random positions for the platforms 
    public float minY = 0f;
    public float maxY = 0.4f;
    public float widthX = 2f;
    public float widthY = 0.5f;
    public float radius;

    //can figure out a code later which will instantiate near the screen area, but for now everything gets instantiated at the first go
    void Start()
    {
        Vector3 platformPosition = new Vector3();
        scoreScript.score = 0;       
        for (int i=0; i<numberOfPlatforms; i++)
        {
            //random numbers created to randomly set up platforms or enemies.
            int platformRandomness = Random.Range(0, 5);
            int superPowerRandomness = Random.Range(0, 5);
            int enemyRandomness = Random.Range(0, 8);

            //set position where things can be instantiated - either platforms or enemies or anything else
            platformPosition.y += widthY + Random.Range(minY, maxY);
            platformPosition.x = Random.Range(-widthX, widthX);


            if (i <= 50)
            {
                //set up only simple platforms for first 50
                Instantiate(simplePlatform, platformPosition, Quaternion.identity);
            } else if (i > 50)
            {
                //set up platforms and enemies
                addPlatformAndEnemy(platformRandomness, enemyRandomness, platformPosition);
                if (platformRandomness <= 1)
                {
                    //set up powers like rocket coin or spring wherever we need
                    addPowers(superPowerRandomness, platformPosition);
                }

            }        
        }
    }

    //based on randomness instantiate things
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

    //based on randomness provide powers like coins rocket spring
    void addPowers(int superPowerRandomness, Vector3 platformPosition)
    {
        //fixed positions for these items now, but can be randomised later
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
