using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyStun : MonoBehaviour
{
    private float stunTimer;
    private float stunCD;
    public bool notStun;

    public Health HS;

    void Start()
    {
        GameObject Player = GameObject.FindGameObjectWithTag("Player");
        HS = Player.GetComponent<Health>();

        stunCD =0;
        stunTimer=0;
        notStun = true;
    }

  
    void Update()
    {
        if (notStun == false)
        {
            
            stunCD += Time.deltaTime;
            if (stunCD >= 4.0f)
            {

                
                stunTimer = 0;
                notStun = true;
                Debug.Log("no stun");
                
            }
        }
        else if (notStun == true)
        {
            stunTimer += Time.deltaTime;
            if (stunTimer <= 5.0f)
            {
                stunCD = 0f;
               
            }
        }
    }



    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "caja")
        {
            Debug.Log("get stunned");
            notStun = false;
        }

        if (notStun == true && gameObject.tag=="enemy1")
        {
            if (other.gameObject.tag == "Player")
            {
                HS.GetHit1();
            }
        }

        if (notStun == true)
        {
            if (other.gameObject.tag == "Player" && gameObject.tag == "enemy2")
            {
                HS.GetHit2();
            }
        }
    }
}
