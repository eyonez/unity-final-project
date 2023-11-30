using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOnCollision : MonoBehaviour
{
    public string targetTag;
    public GameObject flowerPrefab;
    private bool isCollisionHandled = false;

    void Start()
    {
        // Disable the original flower prefab in the hierarchy
        flowerPrefab.SetActive(false);
    }

    void OnCollisionEnter(Collision collision)
    {
        if (!isCollisionHandled && collision.gameObject.CompareTag(targetTag))
        {
            isCollisionHandled = true;

            // Instantiate the flower prefab at the same position as the seed
            GameObject flower = Instantiate(flowerPrefab, transform.position, Quaternion.identity);

            // Activate the clone immediately after instantiation
            flower.SetActive(true);

            // Enable the growth script and start the growth coroutine
            plantGrowth growthScript = flower.GetComponent<plantGrowth>();
            growthScript.enabled = true;
            growthScript.ResetGrowth();  // Reset growth progression
            growthScript.StartGrowth();

            // Destroy the seed after flower instantiation
            Destroy(gameObject);

            // Debug.Log("Flower instantiated");
        }
    }
}
