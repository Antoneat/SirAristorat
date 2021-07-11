using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyModel : MonoBehaviour
{
    Enemy1Health compHealth;

    Rigidbody compRB;

    public bool isAlive;

    public int hp;
    Enemies ee;


    void Awake()
    {
        compHealth = GetComponent<Enemy1Health>();
        compRB = GetComponent<Rigidbody>();
    }

    void Start()
    {
        isAlive = true;
        ee = GetComponent<Enemies>();
        hp = 2;
    }

    void Update()
    {

    }

    void OnTriggerEnter(UnityEngine.Collider other)
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

    public void GetHit()
    {
        hp = hp - 1;

        if (hp == 0)
        {
            ee.Dead();
            // GameObject.Find(gameObject.name + ("spawn point")).GetComponent<Respawn>().Death = true;
            //Destroy(gameObject);
        }
    }
}