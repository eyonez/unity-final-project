using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOnCollision : MonoBehaviour
{
    // Define the tag of the object you want to collide with (e.g., "Plane")
    public string targetTag = "grid";

    // Called when a collision occurs
    void OnCollisionEnter(Collision collision)
    {
        // Check if the collided object has the specified tag
        if (collision.gameObject.CompareTag(targetTag))
        {
            // Destroy the game object this script is attached to
            Destroy(gameObject);
        }
    }
}
