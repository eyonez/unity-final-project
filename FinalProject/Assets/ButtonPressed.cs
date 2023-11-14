
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR;
using Valve.VR.InteractionSystem;

public class ButtonPressed : MonoBehaviour
{
    public GameObject objectToSpawn;
    public Transform BoxDispencer;

    public void OnPress(Hand hand)
    {
        Debug.Log("SteamVR Button pressed!");
        Instantiate(objectToSpawn, BoxDispencer.position, BoxDispencer.rotation);
    
    }

    public void OnCustomButtonPress()
    {
        Debug.Log("We pushed our custom button!");
    }
}
