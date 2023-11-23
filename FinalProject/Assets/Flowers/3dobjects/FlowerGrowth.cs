using UnityEngine;

public class FlowerGrowth : MonoBehaviour
{
    public float growthRate = 1f;  // Adjust this value to control the growth rate
    public float maxPositionY = 1.3f;  // Adjust this value to set the maximum Y position of the flower
    public Vector3 initialSize = new Vector3(0f, 0f, 0f);  // Set the initial size here

    void Start()
    {
        // Set the initial size and position when the game starts
        transform.localScale = initialSize;
        transform.localPosition = Vector3.zero;  // Set initial position (assuming the ground is at Y = 0)
    }

    void Update()
    {
        // Check for both mouse and controller input
        if (Input.GetMouseButtonDown(0) || Input.GetButtonDown("Fire1"))
        {
            GrowFlower();
        }
    }

    void GrowFlower()
    {
        // Increase the Y position of the flower object
        transform.localPosition += new Vector3(0, growthRate, 0);

        // Clamp the Y position to the maximum value
        transform.localPosition = new Vector3(transform.localPosition.x,
                                              Mathf.Clamp(transform.localPosition.y, 0, maxPositionY),
                                              transform.localPosition.z);
    }
}