using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class plantGrowth : MonoBehaviour
{
    public int currentProgression = 0;
    public int timeBetweenGrowths;
    public int maxGrowth;

    private bool startGrowth = false;

    void Start()
    {
        // Disable Growth initially
        enabled = false;

        // Reset currentProgression to 0 at the start
        currentProgression = 0;
    }

    void Update()
    {
        if (startGrowth)
        {
            // Loop the Growth() function
            Growth();
            //Debug.Log("Growth called");

            // Reset the flag after handling the growth logic
            startGrowth = false;
        }
    }

    // Public method to start the growth process
    public void StartGrowth()
    {
        startGrowth = true;
    }

    // Coroutine for controlled growth
    public IEnumerator GrowthCoroutine()
    {
        while (true)
        {
            // Loop the Growth() function
            Growth();
            //Debug.Log("Growth called");

            // Wait for the specified time before the next growth
            yield return new WaitForSeconds(timeBetweenGrowths);
        }
    }

    // Public method to start the growth coroutine
    public void StartGrowth2()
    {
        StartCoroutine(GrowthCoroutine());
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
}
