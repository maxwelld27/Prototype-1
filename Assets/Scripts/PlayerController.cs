using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Detect if the player is pressing the forward or back keys
    public float forwardInput;
    // Detect the player pressing the left or right keys
    public float horizontalInput;
    public float turnSpeed;
        public float Horizontal;  
    // Creating a variable for speed
    public float speed = 20;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        forwardInput = Input.GetAxis("Vertical");
        // Move the car forward
        transform.Translate(Vector3.forward * Time.deltaTime * speed * forwardInput);
        transform.Rotate(Vector3.up, horizontalInput);
    }
}
