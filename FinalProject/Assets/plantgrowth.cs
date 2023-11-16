using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class plantgrowth : MonoBehaviour
{
    private int currentProgression = 0;
    public int timeBetweenGrowths;
    public int maxGrowth;

    void Start()
    {
        // Disable Growth initially
        enabled = false;

        // Reset currentProgression to 0 at the start
        currentProgression = 0;
    }

    void Update()
    {
        // You can add any additional update logic here if needed
    }

    public void Growth()
    {

        // Deactivate the current stage
        transform.GetChild(currentProgression).gameObject.SetActive(false);

        // Increment currentProgression
        currentProgression++;

        // Check if we need to loop back to the first stage
        if (currentProgression >= maxGrowth)
        {
            currentProgression = 0;
        }

        // Activate the new current stage
        transform.GetChild(currentProgression).gameObject.SetActive(true);



    }

}