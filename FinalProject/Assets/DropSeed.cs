using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR;
using Valve.VR.InteractionSystem;

public class DropSeed : MonoBehaviour
{
  
    public GameObject hitted;
  

    void OnTriggerEnter(Collider other)
    {
        Debug.Log("Entered collision");
      
       if (other.tag == "Doritos Organic_1")
       {
            Destroy(hitted);
       }
           
    }

    // Gets called during the stay of object inside the collider area
    void OnTriggerStay(Collider other)
    {
        Debug.Log("Colliding" );
    }

    // Gets called when the object exits the collider area
    void OnTriggerExit(Collider other)
    {
        Debug.Log("Exited collision with");
    }
}