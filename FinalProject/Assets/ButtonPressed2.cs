
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR;
using Valve.VR.InteractionSystem;

public class ButtonPressed2 : MonoBehaviour
{
    public GameObject objectToSpawn;
    public Transform BoxDispencer;
    private GameObject button2;
    private FlowerCounter flowerCounter;

    // Start is called before the first frame update
    void Start()
    {
        // Find the Button2 GameObject by name
        button2 = GameObject.Find("Button2");

        // Deactivate Button2 at the beginning
        if (button2 != null)
        {
            button2.SetActive(false);
        }

        // Find and store reference to FlowerCounter script
        flowerCounter = FindObjectOfType<FlowerCounter>();
    }

    // Update is called once per frame
    void Update()
    {
        // Check if flower1Count is more than 3 before activating Button2
        if (flowerCounter != null && flowerCounter.flower1Count >= 1 && button2 != null)
        {
            button2.SetActive(true);
        }

    }

    public void OnPress(Hand hand)
    {
        //Debug.Log("SteamVR Button pressed!");
        Instantiate(objectToSpawn, BoxDispencer.position, BoxDispencer.rotation);
    }

    public void OnCustomButtonPress()
    {
        //Debug.Log("We pushed our custom button!");
    }
}
