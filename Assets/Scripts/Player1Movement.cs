using UnityEngine;
using System.Collections;

public class Player1Movement : MonoBehaviour
{
    public float speed = 0.05f;
    public GameObject player;

	// Use this for initialization
	void Start ()
    {
	
	}
	
	// Update is called once per frame
	void FixedUpdate ()
    {
        Vector3 playerPos = player.transform.position;
        if (Input.GetAxis("Vertical") > 0.0f && playerPos.y <= 35.5f)
        {
            playerPos.y += speed * Time.deltaTime;
            player.transform.position = playerPos;

        }
        else if (Input.GetAxis("Vertical") < 0.0f && playerPos.y >= -35.5f)
        {
            playerPos.y -= speed * Time.deltaTime;
            player.transform.position = playerPos;
        }

	}
}
