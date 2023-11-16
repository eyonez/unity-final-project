using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOnCollision : MonoBehaviour
{
    public string targetTag = "grid";
    public GameObject flowerPrefab;
    private bool plantGrowing = false;

    void OnCollisionEnter(Collision collision)
    {
        
        if (collision.gameObject.CompareTag(targetTag) && !plantGrowing)
        {
            Debug.Log("Collision occurred");
            Destroy(gameObject);
            plantGrowing = true;

            // Instantiate the flower prefab at the same position as the seed
            
            GameObject flower = Instantiate(flowerPrefab, transform.position, Quaternion.identity);
            // flower.GetComponent<plantgrowth>().enabled = true; // Enable
            flower.GetComponent<plantgrowth>().Growth();
            Debug.Log("Flower instantiated");
        }
    }
}
