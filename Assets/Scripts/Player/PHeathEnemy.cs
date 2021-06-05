using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PHeathEnemy : MonoBehaviour
{

    Health compHealth;
    public bool isAlive;
    public EnemyStun es;
    public EnemyStun es2;

    void Awake()
    {
        compHealth = GetComponent<Health>();
        

    }

    void Start()
    {
        isAlive = true;
        GameObject Enemy1 = GameObject.FindGameObjectWithTag("enemy1");
        GameObject Enemy2 = GameObject.FindGameObjectWithTag("enemy2");
        es = Enemy1.GetComponent<EnemyStun>();
        es2 = Enemy2.GetComponent<EnemyStun>();
    }


    void Update()
    {
        
    }

    void OnCollisionEnter(Collision other)
    {

        if (es.notStun == true)
        {
            if (other.gameObject.tag == "enemy1")
            {
                compHealth.GetHit1();
            }
        }

        if (es2.notStun == true)
        {
            if (other.gameObject.tag == "enemy2")
            {
                compHealth.GetHit2();

                /*if (isAlive)
                {
                    compRendering.PlayDamageFlashing();
                }*/
            }
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
