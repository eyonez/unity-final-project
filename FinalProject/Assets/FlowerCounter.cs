using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class FlowerCounter : MonoBehaviour
{
    public int flower1Count = 0;

    private void Start()
    {
        
    }

    private void Update()
    {
        // Reset flower1Count at the beginning of each frame
        flower1Count = 0;

        // Find all GameObjects with the "Flower1" tag
        GameObject[] flowers1 = GameObject.FindGameObjectsWithTag("Flower1");

        foreach (GameObject flower1 in flowers1)
        {
            plantGrowth flower1Script = flower1.GetComponent<plantGrowth>();

            // Debug log to check the value of currentProgression
            Debug.Log("currentProgression: " + (flower1Script != null ? flower1Script.currentProgression.ToString() : "No plantGrowth script"));

            // Check if the flower is in stage 4
            if (flower1Script != null && flower1Script.currentProgression == 4)
            {
                flower1Count++;
            }
        }

        //Debug.Log("flower1Count: " + flower1Count);


    }


}
