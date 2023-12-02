using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rain : MonoBehaviour
{

    private FlowerCounter flowerCounter;
    public GameObject Rain_Particle;
    //public GameObject bridge;
    public plantGrowth plantGrowthScript;

    private bool isRaining = false;
    private float rainDuration = 20f; // Set the rain duration in seconds
    private float currentRainTime = 0f;

    // Start is called before the first frame update
    void Start()
    {
        Rain_Particle.gameObject.SetActive(false);
        //bridge.gameObject.SetActive(false);

        // Find and store reference to FlowerCounter script
        flowerCounter = FindObjectOfType<FlowerCounter>();
    }

    // Update is called once per frame
    void Update()
    {
        // Check if flower2Count is more than 4 before activating Rain
        if (flowerCounter != null)
        {
            // Debug.Log("flower2Count: " + flowerCounter.flower2Count);  // Check the flower2Count value

            if (flowerCounter.flower2Count >= 4)
            {
                if (!isRaining)
                {
                    StartRaining();
                }
            }
            else
            {
                if (isRaining)
                {
                    StopRaining();
                }
            }
        }

        // Check if it's raining and update the rain timer
        if (isRaining)
        {
            currentRainTime += Time.deltaTime;

            // Check if the rain duration has been reached
            if (currentRainTime >= rainDuration)
            {
                StopRaining();
            }
        }
    }

    // Start raining
    void StartRaining()
    {
        Rain_Particle.gameObject.SetActive(true);
        isRaining = true;
        currentRainTime = 0f; // Reset the rain timer
    }

    // Stop raining
    void StopRaining()
    {
        Rain_Particle.gameObject.SetActive(false);
        isRaining = false;
        currentRainTime = 0f; // Reset the rain timer
        //bridge.gameObject.SetActive(true);
        plantGrowthScript.StartGrowth();
    }
}
