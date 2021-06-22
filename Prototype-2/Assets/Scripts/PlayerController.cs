using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    // Player movement
    public float horizontalInput;
    public float verticalInput;

    // Player movement speed
    public float movementSpeed = 100.0f;

    // Value range that can be negative or positive!
    public float xRange = 10.0f;

    // GameObject to hold a prefab
    public GameObject projectilePrefab;

    public Transform projectileSpawnPoint;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Set a new negative x position with -xRange so Player does not move past that new position
        if (transform.position.x < -xRange) // -xRange = -10.0f
        {
            transform.position = new Vector3(-xRange, transform.position.y, transform.position.z);
        }

        // Set a new positive x position with xRange so Player does not move past that new position
        if (transform.position.x > xRange) // xRange = 10.0f
        {
            transform.position = new Vector3(xRange, transform.position.y, transform.position.z);
        }

        if(Input.GetKeyDown(KeyCode.Space))
        {
            // Press space bar to fire projectile from the player
            // Debug.Log("Space bar pressed!");
            Instantiate(projectilePrefab, projectileSpawnPoint.position, projectilePrefab.transform.rotation);
        }

        // Player Movement
        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");

        // (!)  Multiply horizontalInput to calculate whether the movement goes in
        //      the positive or negative right direction
        transform.Translate(Vector3.right * horizontalInput * Time.deltaTime * movementSpeed);
        transform.Translate(Vector3.forward * verticalInput * Time.deltaTime * movementSpeed);
    }
}
