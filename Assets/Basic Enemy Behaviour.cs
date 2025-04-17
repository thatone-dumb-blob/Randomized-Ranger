using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Basic_Enemy_Behaviour : MonoBehaviour
{       
        public Transform player;
         public float enemySpeed = 3f; // Time interval between each spawn
         private int CurrentHp;
         public int MaxHp = 1;

    void Start ()   
    {
        CurrentHp = MaxHp;
    }
    void OnCollisonEnter2D(Collision2D collision) 
    {
        if(collision.gameObject.CompareTag("Bullet"))
        {
            this.CurrentHp = CurrentHp - 1;
            Debug.Log ("Hit");
            if(CurrentHp <= 0)
            {
                Debug.Log ("Death");
                Destroy(collision.gameObject);
            }
        }
    }
    void Update()
    {
        Vector3 targetPosition = player.position;
        transform.position = Vector3.MoveTowards(transform.position, targetPosition, enemySpeed * Time.deltaTime);


    }
}
