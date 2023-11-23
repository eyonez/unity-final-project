using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class FlowerCounter : MonoBehaviour
{
    public int flower1Count = 0;
    public int flower2Count = 0;

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
            //Debug.Log("currentProgression: " + (flower1Script != null ? flower1Script.currentProgression.ToString() : "No plantGrowth script"));

            // Check if the flower is in stage 4
            if (flower1Script != null && flower1Script.currentProgression == 4)
            {
                flower1Count++;
            }
        }

        //Debug.Log("flower1Count: " + flower1Count);


        // Reset flower1Count at the beginning of each frame
        flower2Count = 0;

        // Find all GameObjects with the "Flower2" tag
        GameObject[] flowers2 = GameObject.FindGameObjectsWithTag("Flower2");

        foreach (GameObject flower2 in flowers2)
        {
            plantGrowth flower2Script = flower2.GetComponent<plantGrowth>();

            // Check if the flower2 is in stage 4
            if (flower2Script != null && flower2Script.currentProgression == 4)
            {
                flower2Count++;
            }
        }

        //Debug.Log("flower2Count: " + flower2Count);
    }


}
