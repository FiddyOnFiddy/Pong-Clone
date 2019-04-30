using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TesticleMovement : MonoBehaviour
{
    public float randomRotation;
    public int rotationDir;


    // Start is called before the first frame update
    void Start()
    {
        rotationDir = Random.Range(1, 4);
        switch (rotationDir)
        {
        case 4:
                randomRotation = Random.Range(45.0f, 75.0f);
                break;
        case 3:
                randomRotation = Random.Range(105.0f, 135.0f);
                break;
        case 2:
                randomRotation = Random.Range(225.0f, 255.0f);
                break;
        case 1:
                randomRotation = Random.Range(285.0f, 315.0f);
                break;
        }

        Debug.Log(rotationDir);

        Vector3 currentRotation = transform.eulerAngles;
        currentRotation.z = randomRotation;
        transform.eulerAngles = currentRotation;

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
