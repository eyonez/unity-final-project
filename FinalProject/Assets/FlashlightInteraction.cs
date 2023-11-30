using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlashlightInteraction : MonoBehaviour
{
    private bool isCollisionDetected = false; // Flag to track collision detection
    public GameObject flashlight;
    public GameObject hiddenBox;
    public plantGrowth plantGrowthScript;

    void Start()
    {
        // Initially, the flower should not be growing
        plantGrowthScript.StopGrowth();
    }

    void Update()
    {
        // Check if the flashlight hits the hidden box
        if (!isCollisionDetected && flashlight.GetComponent<Collider>().bounds.Intersects(hiddenBox.GetComponent<Collider>().bounds))
        {
            // Reset growth for the new flower
            plantGrowthScript.StopGrowth();

            // Start growing from the current stage
            plantGrowthScript.StartGrowth();
            isCollisionDetected = true;
        }
    }
}

