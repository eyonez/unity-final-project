using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rain : MonoBehaviour
{

    private FlowerCounter flowerCounter;
    public GameObject Rain_Particle;

    // Start is called before the first frame update
    void Start()
    {
        Rain_Particle.gameObject.SetActive(false);

        // Find and store reference to FlowerCounter script
        flowerCounter = FindObjectOfType<FlowerCounter>();
    }

    // Update is called once per frame
    void Update()
    {
        // Check if flower2Count is more than 5 before activating Rain
        if (flowerCounter != null)
        {
            //Debug.Log("flower2Count: " + flowerCounter.flower2Count);  // Check the flower2Count value

            if (flowerCounter.flower2Count >= 5)
            {
                Rain_Particle.gameObject.SetActive(true);
            }
        }
    }
}
