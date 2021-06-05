﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class Player : MonoBehaviour
{
    Health compHealth;

    Rigidbody compRB;

   
    public bool isAlive;

    
    void Awake()
    {
        compHealth = GetComponent<Health>();
        compRB = GetComponent<Rigidbody>();
    }

    void Start()
    {
        isAlive = true;
    }

    void Update()
    {
      
    }

    void OnTriggerEnter(UnityEngine.Collider other)
    {
        if (other.gameObject.tag == "HealUp" && compHealth.hp <= 2)
        {
            compHealth.GetHeal();

            Destroy(other.gameObject);
        }

        if (other.gameObject.tag == "Flechas")
        {
            compHealth.GetHit1();
        }


    }

    void OnCollisionEnter(Collision other)
    {

        if (other.gameObject.tag == "Trap1")
        {
            compHealth.GetHit1();
        }

        if (other.gameObject.tag == "trap2")
        {
            compHealth.GetHit2();
        }

        if (other.gameObject.tag == "quesoP1")
        {
            SceneManager.LoadScene("lvl1");
        }
    }
    public void Dead()
    {

        isAlive = false;
        Destroy(gameObject);

        //load scene bla bla al game over de ahi a donde tu quieras 
        //resetea todo uwu

    }
}
