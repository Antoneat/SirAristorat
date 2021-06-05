using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy1Health : MonoBehaviour
{
    public int hp;


    void Start()
    {
        hp = 2;
    }

    void Update()
    {

    }


    public void GetHit()
    {

        hp = hp - 1;
        if (hp == 0)
        {
            GameObject.Find(gameObject.name + ("spawn point")).GetComponent<Respawn>().Death = true;
            Destroy(gameObject);
        }
    }


}
