using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy2Health : MonoBehaviour
{
    public int hp;
    Enemies ee;

    void Start()
    {
        ee = GetComponent<Enemies>();
        hp = 4;
    }

    void Update()
    {

    }

  
    public void GetHit()
    {

        hp = hp - 1;
        if (hp ==0)
        {
            ee.Dead();
            // GameObject.Find(gameObject.name + ("spawn point")).GetComponent<Respawn>().Death = true;
            //Destroy(gameObject);
        }

       
    }


}
