using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using TMPro;

public class Enemy1Health : MonoBehaviour
{
    public int hp;
    Enemy1 ee;

    DmgNunInstance dmg;


    void Start()
    {
        ee = GetComponent<Enemy1>();  
        dmg = GetComponent<DmgNunInstance>();
        hp = 2;        
    }

    void Update()
    {
  
    }

    public void GetHit()
    {
        //dmg.DmgNums();
        hp = hp - 1;
        if (hp == 0)
        {
            ee.Dead();
           // GameObject.Find(gameObject.name + ("spawn point")).GetComponent<Respawn>().Death = true;
            Destroy(gameObject);
        }
    }


}
