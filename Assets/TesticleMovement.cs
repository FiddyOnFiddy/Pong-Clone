using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TesticleMovement : MonoBehaviour
{
    public float randomRotation;
    public int rotationDir;

    public float speed = 5.0f;

    public Vector3 currentRotation;
    public Vector2 reflection;
    public Rigidbody2D rb;

    public Vector2 direction;


    // Start is called before the first frame update
    void Start()
    {
        BallLaunch();
        rb = gameObject.GetComponent<Rigidbody2D>();

    }

    // Update is called once per frame
    void Update()
    {
        BallMovement();
    }

    void BallLaunch()
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

        currentRotation = transform.eulerAngles;
        currentRotation.z = randomRotation;
        transform.eulerAngles = currentRotation;

        Debug.Log(currentRotation);

    }

    void BallMovement()
    {
        transform.Translate(Vector3.up * speed * Time.deltaTime);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {

    }
}
