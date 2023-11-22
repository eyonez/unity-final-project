using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rain : MonoBehaviour
{

    private FlowerCounter flowerCounter;

    // Start is called before the first frame update
    void Start()
    {
        gameObject.SetActive(false);

        // Find and store reference to FlowerCounter script
        flowerCounter = FindObjectOfType<FlowerCounter>();
    }

    // Update is called once per frame
    void Update()
    {
        // Check if flower2Count is more than 5 before activating Rain
        if (flowerCounter != null && flowerCounter.flower2Count >= 5)
        {
            gameObject.SetActive(true);
        }
    }
}
