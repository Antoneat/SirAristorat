using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy1 : MonoBehaviour
{
    Enemy1Health compHealth;

    Rigidbody compRB;

    public bool isAlive;
 
    bool moving;


    void Awake()
    {
        compHealth = GetComponent<Enemy1Health>();
        compRB = GetComponent<Rigidbody>();
    }

    void Start()
    {
        isAlive = true;
    }

    void Update()
    {
      
    }

    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "PlayerWep")
        {
            compHealth.GetHit();
        }

      
    }
    public void Dead()
    {
        isAlive = false;

        Destroy(gameObject);
    }
}