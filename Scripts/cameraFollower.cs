using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraFollower : MonoBehaviour
{
    public Transform myCharacter;
    public GameObject platform;
    public GameObject[] allPlatforms;
    private Vector3 stageDimensions;

    // Start is called before the first frame update
    void Start()
    {
        stageDimensions = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, 0));
    }

    void LateUpdate()
    {
        if (myCharacter.position.y > transform.position.y)
        {
            transform.position = new Vector3(transform.position.x, myCharacter.position.y, transform.position.z);
            scoreScript.score += 1;
        }
    }
   
}
