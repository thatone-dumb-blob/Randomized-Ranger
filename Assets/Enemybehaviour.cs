using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{       
        public Transform player;
         public float enemySpeed = 3f; // Time interval between each spawn

    // Update is called once per frame
    void Update()
    {
        Vector3 targetPosition = player.position;
        transform.position = Vector3.MoveTowards(transform.position, targetPosition, enemySpeed * Time.deltaTime);

    }
}
