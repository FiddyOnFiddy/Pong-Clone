using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{

    public int speed = 10;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Movement();
    }

    void Movement()
    {

        if (Input.GetKey(KeyCode.W) && transform.tag == "Player1" && transform.position.y <= 4.25f)
        {
            Vector2 currentPos = transform.position;

            currentPos.y += 1 * speed * Time.deltaTime;

            transform.position = currentPos;
        }
        else if (Input.GetKey(KeyCode.S) && transform.tag == "Player1" && transform.position.y >= -4.25f)
        {
            Vector2 currentPos = transform.position;

            currentPos.y -= 1 * speed * Time.deltaTime;

            transform.position = currentPos;
        }

        if (Input.GetKey(KeyCode.UpArrow) && transform.tag == "Player2" && transform.position.y <= 4.25f)
        {
            Vector2 currentPos = transform.position;

            currentPos.y += 1 * speed * Time.deltaTime;

            transform.position = currentPos;
        }
        else if (Input.GetKey(KeyCode.DownArrow) && transform.tag == "Player2" && transform.position.y >= -4.25f)
        {
            Vector2 currentPos = transform.position;

            currentPos.y -= 1 * speed * Time.deltaTime;

            transform.position = currentPos;
        }

    }
}
