
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR;
using Valve.VR.InteractionSystem;

public class ButtonPressed5 : MonoBehaviour
{
    public GameObject objectToSpawn;
    public Transform BoxDispencer;
    private GameObject button5;
    private FlowerCounter flowerCounter;

    // Start is called before the first frame update
    void Start()
    {
        // Find the Button5 GameObject by name
        button5 = GameObject.Find("Button5");

        // Deactivate Button5 at the beginning
        if (button5 != null)
        {
            button5.SetActive(false);
        }

        // Find and store reference to FlowerCounter script
        flowerCounter = FindObjectOfType<FlowerCounter>();
    }

    // Update is called once per frame
    void Update()
    {

        // Check if flower4Count is more than 3 before activating Button5
        if (flowerCounter != null && flowerCounter.flower4Count >= 3 && button5 != null)
        {
            button5.SetActive(true);
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
