
using UnityEngine;

public class Playermovement : MonoBehaviour
{
        public float moveSpeed = 7f; // Movement speed of the player
        public float dashSpeed = 50f;
        public float dashDuration = 0.5f;
        public float dashCooldown = 2f; 

        private float dashTime = 0f; // Time remaining for the dash
        private float cooldownTime = 0f; // Time remaining for the cooldown


    // Update is called once per frame
    void Update()
    {   
        float movex = Input.GetAxisRaw("Horizontal") * moveSpeed * Time.deltaTime;
        float movey = Input.GetAxisRaw("Vertical") * moveSpeed * Time.deltaTime;
    transform.Translate(new Vector3(movex,movey,0));
      
        if (Input.GetKey(KeyCode.LeftShift) && dashCooldown <= 0f) {
            Dash();
        }
        if (dashDuration > 0f) {
            dashDuration -= Time.deltaTime;
            moveSpeed = dashSpeed;
        }
        else
        { 
            if (dashCooldown > 0f){
                dashCooldown -= Time.deltaTime;
                }
        else {
            moveSpeed = 7f; }
        }
    }

    private void Dash()
    {
        dashTime = dashDuration;  // Set dash time duration
        cooldownTime = dashCooldown;  // Set cooldown time
    }
}



