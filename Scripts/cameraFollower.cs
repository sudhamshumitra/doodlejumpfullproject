using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraFollower : MonoBehaviour
{
    public Transform myCharacter;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void LateUpdate()
    {
        if (myCharacter.position.y > transform.position.y)
        {
            transform.position = new Vector3(transform.position.x, myCharacter.position.y, transform.position.z);
        }
    }
}
