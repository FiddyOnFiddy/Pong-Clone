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

    public Ray2D ray;
    public RaycastHit2D hit;
    public Vector3 direction;

    public Vector3 initialVeclocity;
    public Vector3 lastFrameVelocity;
    public float minVelocity = 10.0f;



    // Start is called before the first frame update
    void Start()
    {
        BallLaunch();
        rb = gameObject.GetComponent<Rigidbody2D>();
        rb.velocity = initialVeclocity;
        rb.velocity = transform.up * speed;
    }

    // Update is called once per frame
    void Update()
    {

        lastFrameVelocity = rb.velocity;
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
        //transform.Translate(Vector2.up * speed * Time.deltaTime);        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Bounce(collision.contacts[0].normal);
        minVelocity += 2;
    }

    void Bounce(Vector3 collisionNormal)
    {
        float speed = lastFrameVelocity.magnitude;
        Vector2 direction = Vector2.Reflect(lastFrameVelocity.normalized, collisionNormal);

        Debug.Log("Out Direction: " + direction);
        rb.velocity = direction * Mathf.Max(speed , minVelocity);
    }
}
