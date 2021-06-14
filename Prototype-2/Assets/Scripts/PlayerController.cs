using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    // Variable for player movement - left to right
    public float horizontalInput;

    // Movement Speed
    public float movementSpeed = 100.0f;

    // A variable for a value range that can be negative or positive!
    public float xRange = 10.0f;

    // GameObject to hold a prefab
    public GameObject projectilePrefab;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Set a new negative x position with -xRange so Player does not move past that new position
        if (transform.position.x < -xRange)
        {
            transform.position = new Vector3(-xRange, transform.position.y, transform.position.z);
        }

        // Set a new positive x position with xRange so Player does not move past that new position
        if (transform.position.x > xRange)
        {
            transform.position = new Vector3(xRange, transform.position.y, transform.position.z);
        }

        // Player Movement
        horizontalInput = Input.GetAxis("Horizontal");

        // (!)  Multiply horizontalInput to calculate whether the movement goes in
        //      the positive or negative right direction
        transform.Translate(Vector3.right * horizontalInput * Time.deltaTime * movementSpeed);
    }
}
