using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Playermovement : MonoBehaviour
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
        float movement.x = Input.GetAxisRaw("Horizontal") * moveSpeed * Time.deltaTime;
        float movement.y = Input.GetAxisRaw("Vertical") * moveSpeed * Time.deltaTime;
    }
}
