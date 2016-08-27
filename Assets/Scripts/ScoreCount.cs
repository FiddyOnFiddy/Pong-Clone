using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ScoreCount : MonoBehaviour
{

    public int playerOneScore;
    public int playerTwoScore;
    public GameData gameData;

    public Text p1Score;
    public Text p2Score;

    public bool isDead = false;

    // Use this for initialization
    void Start ()
    {

	}
	
	// Update is called once per frame
	void Update ()
    {
        gameData.playerOneScore = playerOneScore;
        gameData.playerTwoScore = playerTwoScore;
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.name == "RightTrigger")
        {
            playerOneScore += 1;
            p1Score.text = playerOneScore.ToString();
            isDead = true;
        }

        else if (other.name == "LeftTrigger")
        {
            playerTwoScore += 1;
            p2Score.text = playerTwoScore.ToString();
            isDead = true;
        }
    }
}
