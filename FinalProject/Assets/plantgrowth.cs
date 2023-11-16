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
        if (currentProgression != maxGrowth)
        {
            transform.GetChild(currentProgression).gameObject.SetActive(true);
        }

        if (currentProgression > 0 && currentProgression < maxGrowth)
        {
            transform.GetChild(currentProgression - 1).gameObject.SetActive(false);
        }

        if (currentProgression < maxGrowth)
        {
            currentProgression++;
        }
        else
        {
            // Reset currentProgression to 0 when it reaches the maximum growth
            currentProgression = 0;
        }
    }
}