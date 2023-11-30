
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR;
using Valve.VR.InteractionSystem;

public class ButtonPressed6 : MonoBehaviour
{
    public GameObject objectToSpawn;
    public Transform BoxDispencer;
    private GameObject button6;
    private FlowerCounter flowerCounter;

    // Start is called before the first frame update
    void Start()
    {
        // Find the Button6 GameObject by name
        button6 = GameObject.Find("Button6");

        // Deactivate Button6 at the beginning
        if (button6 != null)
        {
            button6.SetActive(false);
        }

        // Find and store reference to FlowerCounter script
        flowerCounter = FindObjectOfType<FlowerCounter>();
    }

    // Update is called once per frame
    void Update()
    {

        // Check if flower5Count is more than 5 before activating Button6
        if (flowerCounter != null && flowerCounter.flower5Count >= 5 && button6 != null)
        {
            button6.SetActive(true);
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
