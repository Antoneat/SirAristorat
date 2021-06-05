using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy2 : MonoBehaviour
{
    Enemy2Health compHealth;

    Rigidbody compRB;

    public bool isAlive;

    void Awake()
    {
        compHealth = GetComponent<Enemy2Health>();
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

        //destroy bih

    }
}

