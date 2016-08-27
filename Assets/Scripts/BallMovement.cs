using UnityEngine;
using System.Collections;

public class BallMovement : MonoBehaviour
{

    public Rigidbody rb;
    public float speed = 1000.0f;
    public GameObject ball;
    public ScoreCount scoreCount;
    public float timeLeft = 2.0f;

    public Vector3 resetPos;

    // Use this for initialization

    void Start()
    {
        resetPos = ball.transform.position;
        Launch();
    }

    // Update is called once per frame
    void Update()
    {

        Reset();
    }

    void Launch()
    {
        Vector3 ballRotation = ball.transform.eulerAngles;
        ballRotation.z = Random.Range(0.0f, 360.0f);
        ball.transform.eulerAngles = ballRotation;

        Debug.Log(ball.transform.eulerAngles.z);

        rb.AddRelativeForce(new Vector3(0.0f, speed * 10, 0.0f));
    }

    void Reset()
    {


        if (scoreCount.isDead)
        {
            rb.velocity = new Vector3(0.0f, 0.0f, 0.0f);
            ball.transform.position = resetPos;
            timeLeft -= Time.deltaTime;
        }

        if (timeLeft < 0.0f)
        {
            Launch();
            timeLeft = 2.0f;
            scoreCount.isDead = false;

        }
    }
}
