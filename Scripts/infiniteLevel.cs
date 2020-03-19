using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class infiniteLevel : MonoBehaviour
{
    public GameObject platform;
    public int numberOfPlatforms = 30;
    public float minY = 0f;
    public float maxY = 0.4f;
    public float widthX = 2f;
    public float widthY = 0.5f;
    // Start is called before the first frame update
    void Start()
    {
        Vector3 platformPosition = new Vector3();

        for (int i=0; i<numberOfPlatforms; i++)
        {
            platformPosition.y += widthY + Random.Range(minY, maxY);
            platformPosition.x = Random.Range(-widthX, widthX);
            Instantiate(platform, platformPosition, Quaternion.identity);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
