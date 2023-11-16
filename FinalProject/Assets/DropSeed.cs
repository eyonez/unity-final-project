using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR;
using Valve.VR.InteractionSystem;

public class DropSeed : MonoBehaviour
{
  
    public GameObject hitted;
   // public GameObject col;

    void OnTriggerEnter(Collider objectName)
    {
        Debug.Log("Entered collision with " + objectName.gameObject.name);
      
       // if (objectName.gameObject.name == "Wooden_Box")
       // {
            Destroy(hitted);
      //  }
           
    }

    // Gets called during the stay of object inside the collider area
    void OnTriggerStay(Collider objectName)
    {
        Debug.Log("Colliding with " + objectName.gameObject.name);
    }

    // Gets called when the object exits the collider area
    void OnTriggerExit(Collider objectName)
    {
        Debug.Log("Exited collision with " + objectName.gameObject.name);
    }
}