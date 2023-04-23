using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class task3 : MonoBehaviour
{
    [SerializeField] int startingHealth = 30;
    void Start()
    {

    }

    
    void Update()
    {
        //foreach (GameObject enemy in enemies)
        //{
        //    if (enemy != null && enemy.transform.position.y < -5)
        //    {
        //        Destroy(enemy);
        //    }
        //}

        //if (currentHealth <= 0)
        //{
        //    Destroy(gameObject);
        //}
    }

    void OnCollisionEnter(Collision collision)
    {
        //if (collision.gameObject.CompareTag("Enemy"))
        //{
            
        //}
        Destroy(collision.gameObject);
        Attack();
    }

    private void Attack()
    {
        startingHealth -= 10;
        if (startingHealth <= 0)
        {
            Destroy(gameObject);
        }
    }
}
