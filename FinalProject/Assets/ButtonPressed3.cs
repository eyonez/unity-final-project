
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR;
using Valve.VR.InteractionSystem;

public class ButtonPressed3 : MonoBehaviour
{
    public GameObject objectToSpawn;
    public Transform BoxDispencer;
    private GameObject button3;
    private FlowerCounter flowerCounter;

    // Start is called before the first frame update
    void Start()
    {
        // Find the Button3 GameObject by name
        button3 = GameObject.Find("Button3");

        // Deactivate Button3 at the beginning
        if (button3 != null)
        {
            button3.SetActive(false);
        }

        // Find and store reference to FlowerCounter script
        flowerCounter = FindObjectOfType<FlowerCounter>();
    }

    // Update is called once per frame
    void Update()
    {

        // Check if flower2Count is more than 3 before activating Button3
        if (flowerCounter != null && flowerCounter.flower2Count >= 1 && button3 != null)
        {
            button3.SetActive(true);
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
