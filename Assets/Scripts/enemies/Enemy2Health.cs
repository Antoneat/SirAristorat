﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy2Health : MonoBehaviour
{
    public int hp;
    Enemy2 ee;

    void Start()
    {
        hp = 4;
    }

    void Update()
    {

    }

  
    public void GetHit()
    {

        hp = hp - 1;
        if (hp <=0)
        {
            ee.Dead();
            GameObject.Find(gameObject.name + ("spawn point")).GetComponent<Respawn>().Death = true;
            Destroy(gameObject);
        }

       
    }


}
