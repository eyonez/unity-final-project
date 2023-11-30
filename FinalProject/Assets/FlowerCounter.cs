using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class FlowerCounter : MonoBehaviour
{
    public int flower1Count = 0;
    public int flower2Count = 0;
    public int flower3Count = 0;
    public int flower4Count = 0;
    public int flower5Count = 0;
    public int flower6Count = 0;

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


        // Reset flower3Count at the beginning of each frame
        flower3Count = 0;

        // Find all GameObjects with the "Flower3" tag
        GameObject[] flowers3 = GameObject.FindGameObjectsWithTag("Flower3");

        foreach (GameObject flower3 in flowers3)
        {
            plantGrowth flower3Script = flower3.GetComponent<plantGrowth>();

            // Check if the flower3 is in stage 4
            if (flower3Script != null && flower3Script.currentProgression == 4)
            {
                flower3Count++;
            }
        }

        //Debug.Log("flower3Count: " + flower3Count);


        // Reset flower4Count at the beginning of each frame
        flower4Count = 0;

        // Find all GameObjects with the "Flower4" tag
        GameObject[] flowers4 = GameObject.FindGameObjectsWithTag("Flower4");

        foreach (GameObject flower4 in flowers4)
        {
            plantGrowth flower4Script = flower4.GetComponent<plantGrowth>();

            // Check if the flower4 is in stage 4
            if (flower4Script != null && flower4Script.currentProgression == 4)
            {
                flower4Count++;
            }
        }

        //Debug.Log("flower4Count: " + flower4Count);


        // Reset flower5Count at the beginning of each frame
        flower5Count = 0;

        // Find all GameObjects with the "Flower5" tag
        GameObject[] flowers5 = GameObject.FindGameObjectsWithTag("Flower5");

        foreach (GameObject flower5 in flowers5)
        {
            plantGrowth flower5Script = flower5.GetComponent<plantGrowth>();

            // Check if the flower5 is in stage 4
            if (flower5Script != null && flower5Script.currentProgression == 4)
            {
                flower5Count++;
            }
        }

        //Debug.Log("flower5Count: " + flower5Count);


        // Reset flower6Count at the beginning of each frame
        flower6Count = 0;

        // Find all GameObjects with the "Flower6" tag
        GameObject[] flowers6 = GameObject.FindGameObjectsWithTag("Flower6");

        foreach (GameObject flower6 in flowers6)
        {
            plantGrowth flower6Script = flower6.GetComponent<plantGrowth>();

            // Check if the flower6 is in stage 4
            if (flower6Script != null && flower6Script.currentProgression == 4)
            {
                flower6Count++;
            }
        }

        //Debug.Log("flower6Count: " + flower6Count);
    }


}
