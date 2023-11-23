using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rain : MonoBehaviour
{

    private FlowerCounter flowerCounter;
    public GameObject Rain_Particle;
    public bool hasRained = false;

    // Timer
    // https://stackoverflow.com/questions/73058385/making-a-5-second-timer-for-a-prefab
    public float secsToRain;

    // Start is called before the first frame update
    void Start()
    {
        Rain_Particle.gameObject.SetActive(false);

        // Find and store reference to FlowerCounter script
        flowerCounter = FindObjectOfType<FlowerCounter>();
    }

    // Update is called once per frame
    void Update()
    {
        

        // Check if flower2Count is more than 5 before activating Rain
        if (flowerCounter != null)
        {
            //Debug.Log("flower2Count: " + flowerCounter.flower2Count);  // Check the flower2Count value

            if (flowerCounter.flower2Count >= 5 && !hasRained)
            {
                // Add to timer
                secsToRain -= Time.deltaTime;

                Rain_Particle.gameObject.SetActive(true);
                if (secsToRain <= 15)
                {
                    Rain_Particle.gameObject.SetActive(false);
                    hasRained = true;

                    // Insert code to grow bridge plant
                }
            }
        }
    }
}
