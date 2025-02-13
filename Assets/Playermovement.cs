
using UnityEngine;

public class Playermovement : MonoBehaviour
{
        public float moveSpeed = 5f; // Movement speed of the player

    // Update is called once per frame
    void Update()
    {   
        float movex = Input.GetAxisRaw("Horizontal") * moveSpeed * Time.deltaTime;
        float movey = Input.GetAxisRaw("Vertical") * moveSpeed * Time.deltaTime;
    transform.Translate(new Vector3(movex,movey,0));
    }
}
