using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class plantGrowth : MonoBehaviour
{
    public int currentProgression = 0;
    public int timeBetweenGrowths;
    public int maxGrowth;

    private bool isGrowing = false; // Add a flag to control growth

    void Start()
    {
        // Disable Growth initially
        enabled = false;

        // Reset currentProgression to 0 at the start
        currentProgression = 0;
    }

    void Update()
    {
        if (isGrowing)
        {
            // Loop the Growth() function
            Growth();
        }
    }

    // Public method to start the growth process
    public void StartGrowth()
    {
        isGrowing = true;
        StartCoroutine(GrowthCoroutine());
    }

    // Coroutine for controlled growth
    public IEnumerator GrowthCoroutine()
    {
        while (isGrowing && currentProgression < maxGrowth)
        {
            // Loop the Growth() function
            Growth();
            //Debug.Log("Growth called");

            // Wait for the specified time before the next growth
            yield return new WaitForSeconds(timeBetweenGrowths);
        }
    }

    // Public method to stop growth
    public void StopGrowth()
    {
        isGrowing = false;
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
        if (currentProgression >= maxGrowth)
        {
            // Once it reaches the maximum growth, keep looping stage 4
            currentProgression = maxGrowth - 1;
        }
    }

    public void ResetGrowth()
    {
        currentProgression = 0;

        for (int i = 0; i < maxGrowth; i++)
        {
            transform.GetChild(i).gameObject.SetActive(i == 0);
        }
    }
}

