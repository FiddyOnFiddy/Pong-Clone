using UnityEngine;
using System.Collections;

public class Player2AI : MonoBehaviour
{
    public GameObject ball;
    public bool canMove = false;

    public float speed = 100;

	// Use this for initialization
	void Start ()
    {

	}
	
	// Update is called once per frame
	void FixedUpdate ()
    {
        if (ball.transform.position.y <= 36.5f && ball.transform.position.y >= -36.5f)
        {
            canMove = true;
        }

        else
        {
            canMove = false;
        }
        

        if (canMove)
        {
            float step = speed * Time.deltaTime;
            transform.position = Vector3.MoveTowards(new Vector3(80.0f, transform.position.y, -50.0f), new Vector3(80.0f, ball.transform.position.y, 0.0f), step);
            /*
            Vector3 playerPos = this.transform.position;
            playerPos.y = ball.transform.position.y;
            this.transform.position = playerPos;
            */
        }
    }
}
