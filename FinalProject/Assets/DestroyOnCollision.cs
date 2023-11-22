using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOnCollision : MonoBehaviour
{
    public string targetTag;
    public GameObject flowerPrefab;
    public bool plantGrowing = false;

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag(targetTag) && !plantGrowing)
        {
            Destroy(gameObject);
            plantGrowing = true;

            // Instantiate the flower prefab at the same position as the seed
            GameObject flower = Instantiate(flowerPrefab, transform.position, Quaternion.identity);

            // Enable the growth script and start the growth coroutine
            flower.GetComponent<plantGrowth>().enabled = true;
            flower.GetComponent<plantGrowth>().StartGrowth2();

            //Debug.Log("Flower instantiated");
        }
    }
}
