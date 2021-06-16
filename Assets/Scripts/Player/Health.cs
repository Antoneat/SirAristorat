﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    public int hp;

    private bool vulnerable = true;
    private float vulTimer = 0f;
    private float vulCD = 0f;

    //ui d vida <3 = 3;

    void Start()
    {
        hp = 3;
       vulnerable = true;
    }

    void Update()
    {
        if (vulnerable==false)
        {
            vulCD += Time.deltaTime;
            if (vulCD >= 2.0f)
            {
                vulTimer = 0;
                vulnerable = true;
                Debug.Log("GodModeEnded");
            }
        }
        else if (vulnerable==true)
        {
            vulTimer += Time.deltaTime;
            if (vulTimer <= 4.0f)
            {
                vulCD = 0f;
                
            }
        }

    }

    public void GodMode()
    {
        Debug.Log("GodMode");
        if (vulCD <= 2)
        {
            vulnerable = false;
        }
     }

    public void GetHeal()
    {
        if (hp <= 2)
        {
            hp = hp + 1;
        }
    }
    public void GetHit1()
    {
        if (vulnerable)
        {
            hp = hp - 1;
            vulnerable = false;
            Debug.Log("GodMode");

            if (hp <= 0)
            {
                GetComponent<Player>().Dead();
            }
        }
    }

    public void GetHit2()
    {
        if (vulnerable)
        {
            hp = hp - 2;
            vulnerable = false;
           Debug.Log("GodMode");

            if (hp <= 0)
            {
                GetComponent<Player>().Dead();
            }
        }
    }
}