using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemies : MonoBehaviour
{
    Enemy1Health compHealth;

    Rigidbody compRB;

    public bool isAlive;

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
}