using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlashlightInteraction : MonoBehaviour 
{
    public Transform hitbox; //this script goes on the hitbox, which should be a trigger
    public GameObject plant;

    private bool flashlightColliding = false;

    // Update is called once per frame
    void Update()
    {
        if (flashlightColliding)
        {
            //******animate plant growth here******
        }
        else
        {
        
        }

    }

    public void StopGrowth() { flashlightColliding = false; }
    public void GrowPlant() { flashlightColliding = true; }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Tool") { GrowPlant(); Debug.Log("Colliding"); } //make sure the flashlight has the 'Tool' tag
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Tool") { StopGrowth(); }
    }
}
