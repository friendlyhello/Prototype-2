using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCollisionsX : MonoBehaviour
{

    // Custom override for OnTriggerEnter
    private void OnTriggerEnter(Collider other)
    {
        //Destroy this game object
        Destroy(gameObject);

        // Destroy "other" game object (animal)
        Destroy(other.gameObject);
    }
}
