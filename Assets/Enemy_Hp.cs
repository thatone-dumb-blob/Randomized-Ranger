using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Enemy_Hp : MonoBehaviour
{
    public int maxHealth = 3;
    private int CurrentHp;
    // Start is called before the first frame update
    void Start()
    {
        CurrentHp = maxHealth;
    }
        public void TakeDamage(int dmg_taken)
    {
        CurrentHp -= dmg_taken;

        if (CurrentHp <= 0)
        {
            Destroy(gameObject); 
        }
    }

    void OnCollisionEnter2D(Collision2D collision)
{
    if (collision.gameObject.tag == "Bullet")
    {   
        Debug.Log ("Hit");
        Destroy(collision.gameObject); 
        TakeDamage (1);
    }
}
}
