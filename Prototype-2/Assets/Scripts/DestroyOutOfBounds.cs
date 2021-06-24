using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{
    // Define the top and lower bounds of the gameplay space
    private int topBounds = 30;
    private int lowerBounds = -10;
    private float sideBound = 30;

    // Access GameManager
    public GameManager gameManager;

    // Start is called before the first frame update
    void Start()
    {
        // Reference to Game Manager
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.z > topBounds)
        {
            Destroy(gameObject);
        }

        else if (transform.position.z < lowerBounds)
        {
            gameManager.AddLives(-1);
            Destroy(gameObject);
        }

        else if (transform.position.x > sideBound)
        {
            gameManager.AddLives(-1);
            Destroy(gameObject);
        }

        else if (transform.position.x < -sideBound)
        {
            gameManager.AddLives(-1);
            Destroy(gameObject);
        }
    }
}
