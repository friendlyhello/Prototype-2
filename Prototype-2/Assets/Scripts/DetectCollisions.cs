using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCollisions : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // Custom override for OnTriggerEnter
    private void OnTriggerEnter(Collider other)
    {
        //Destroy this game object
        Destroy(gameObject);

        // Destroy "other" game object (animal)
        Destroy(other.gameObject);
    }
}
