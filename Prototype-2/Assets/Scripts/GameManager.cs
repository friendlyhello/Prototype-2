using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    // Variables for score and lives
    public int score;
    public int lives;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    //** METHODS */

    // Method for updating score
    public void AddScore(int value)
    {
        score += value;
        Debug.Log("Score = " + score);  
    }

    // Method for updating lives
    public void AddLives(int value)
    {
        lives += value;

        if (lives <= 0)
        {
            Debug.Log("Game Over!");
        }

        Debug.Log("Lives = " + lives);
    }

}
