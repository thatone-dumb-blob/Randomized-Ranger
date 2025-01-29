using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    
    // Start is called before the first frame update
    void Start()
    {
        public float moveSpeed = 5f; // Movement speed of the player
    private Vector2 movement; // Vector to store movement input
    }

    // Update is called once per frame
    void Update()
    {
         // Get input from the horizontal (A/D or Arrow keys) and vertical (W/S or Arrow keys)
        movement.x = Input.GetAxisRaw("Horizontal"); // -1 = left, 1 = right
        movement.y = Input.GetAxisRaw("Vertical");   // -1 = down, 1 = up
        
    }
    void FixedUpdate()
    {
         if (movement.magnitude > 0)
        {
            movement.Normalize();
        }
        transform.Translate(movement * moveSpeed * Time.fixedDeltaTime)
    }
}
