using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bridge2Growth : MonoBehaviour
{

    private FlowerCounter flowerCounter;
    public plantGrowth plantGrowthScript;


    private bool startBridgeGrowing = false;
    private float bridgeGrowingDelay = 5f; // Set the delay for starting the bridge growing in seconds
    private float currentDelayTime = 0f;

    // Start is called before the first frame update
    void Start()
    {

        // Find and store reference to FlowerCounter script
        flowerCounter = FindObjectOfType<FlowerCounter>();
    }

    // Update is called once per frame
    void Update()
    {
        // Check if flower5Count is more than 0 before starting the bridge growing
        if (flowerCounter != null)
        {
            if (flowerCounter.flower5Count >= 1)
            {
                currentDelayTime += Time.deltaTime;

                // Check if the delay time has been reached
                if (currentDelayTime >= bridgeGrowingDelay)
                {
                    StartBridgeGrowing();
                }
            }
        }

    }


    // Start bridge growing
    void StartBridgeGrowing()
    {
        // Add your logic for starting the bridge growing here
        // For example, you can call a method from the plantGrowthScript
        plantGrowthScript.StartGrowth();

        // Reset the delay timer
        currentDelayTime = 0f;

        // Set a flag to ensure this block is executed only once
        startBridgeGrowing = true;
    }
}
