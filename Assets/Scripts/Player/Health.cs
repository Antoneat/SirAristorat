using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Health : MonoBehaviour
{
    public int hp;

    private bool vulnerable = true;
    private float vulTimer = 0f;
    private float vulCD = 0f;

    public bool isAlive;
    public EnemyStun es;
    public EnemyStun es2;
    void Awake()
    {
        GameObject Enemy1 = GameObject.FindGameObjectWithTag("enemy1");
        GameObject Enemy2 = GameObject.FindGameObjectWithTag("enemy2");
        es = Enemy1.GetComponent<EnemyStun>();
        es2 = Enemy2.GetComponent<EnemyStun>();
    }


    void Start()
    {
        hp = 3;
       vulnerable = true;

        isAlive = true;

    }

    void Update()
    {
        if (vulnerable==false)
        {
            vulCD += Time.deltaTime;
            if (vulCD >= 0.5f)
            {
                vulTimer = 0;
                vulnerable = true;
                Debug.Log("GodModeEnded");
            }
        }
        else if (vulnerable==true)
        {
            vulTimer += Time.deltaTime;
            if (vulTimer <= 1.0f)
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
            HpText.hpV += 1;
        }
    }

    public void GetHit1()
    {
        if (vulnerable)
        {
            hp = hp - 1;
            HpText.hpV -= 1;
            vulnerable = false;
            Debug.Log("GodMode");

            if (hp <= 0)
            {
                Dead();
               
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
                HpText.hpV -= 1;
                Dead();
            }
        }
    }

    void OnCollisionEnter(Collision other)
    {

        if (es.notStun == true)
        {
            if (other.gameObject.tag == "enemy1")
            {
                GetHit1();
            }
        }

        if (es2.notStun == true)
        {
            if (other.gameObject.tag == "enemy2")
            {
                GetHit2();
            }
        }


    }

    public void Dead()
    {

        isAlive = false;
        Destroy(gameObject);
        SceneManager.LoadScene("GameO");
    }
}
