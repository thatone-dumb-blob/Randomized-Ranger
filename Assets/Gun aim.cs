using UnityEngine;

public class Gun : MonoBehaviour
{
    public Transform player; // Assign the Player in the Inspector
    public float gunDistance = 5f; // Distance from player

    void Update()
    {
        RotateAroundPlayer();
    }

    void RotateAroundPlayer()
    {
        Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        Vector3 direction = (mousePos - player.position).normalized; // Get direction
        transform.position = player.position + direction * gunDistance; // Keep fixed distance
        float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.Euler(0, 0, angle); // Rotate towards mouse
    }
}

