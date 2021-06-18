using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyStun : MonoBehaviour
{
    private float stunTimer;
    private float stunCD;
    public bool notStun;
    
   
    void Start()
    {
        stunCD=0;
        stunTimer=0;
        notStun = true;
      //GameObject.Find("Player").GetComponent<PHeathEnemy>().enabled = true;
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

    /*IEnumerator GetStunned()
    {
        yield return new WaitForSeconds(6f);
        Debug.Log("no longer stunned");
        GameObject.Find("Player").GetComponent<PHeathEnemy>().enabled = true;
    }*/

    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "caja")
        {
            Debug.Log("get stunned");
            notStun = false;
        }
    }
}
