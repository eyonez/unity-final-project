
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR;
using Valve.VR.InteractionSystem;

public class ButtonPressed4 : MonoBehaviour
{
    public GameObject objectToSpawn;
    public Transform BoxDispencer;
    private GameObject button4;
    private FlowerCounter flowerCounter;

    // Start is called before the first frame update
    void Start()
    {
        // Find the Button4 GameObject by name
        button4 = GameObject.Find("Button4");

        // Deactivate Button4 at the beginning
        if (button4 != null)
        {
            button4.SetActive(false);
        }

        // Find and store reference to FlowerCounter script
        flowerCounter = FindObjectOfType<FlowerCounter>();
    }

    // Update is called once per frame
    void Update()
    {

        // Check if flower3Count is more than 2 before activating Button4
        if (flowerCounter != null && flowerCounter.flower3Count >= 1 && button4 != null)
        {
            button4.SetActive(true);
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
