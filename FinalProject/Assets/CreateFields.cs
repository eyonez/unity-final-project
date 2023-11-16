using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateFields : MonoBehaviour
{

    public GameObject hitted;
    public GameObject field;

    public GameObject HandRake;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       
            Instantiate(field, hitted.transform.position, Quaternion.identity);
            Destroy(hitted);
   
    }
}
