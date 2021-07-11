using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerModel : MonoBehaviour
{
    public int hp;

    private bool vulnerable = true;
    private float vulTimer = 0f;
    private float vulCD = 0f;

    public bool isAlive;

    Rigidbody compRB;


    void Awake()
    {
        
        compRB = GetComponent<Rigidbody>();
    }


    void Start()
    {
        hp = 3;
        vulnerable = true;

        isAlive = true;

    }

    void Update()
    {
        if (vulnerable == false)
        {
            vulCD += Time.deltaTime;
            if (vulCD >= 0.5f)
            {
                vulTimer = 0;
                vulnerable = true;
                Debug.Log("GodModeEnded");
            }
        }
        else if (vulnerable == true)
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

    public void Dead()
    {

        isAlive = false;
        Destroy(gameObject);
        SceneManager.LoadScene("GameO");
    }


     void OnTriggerEnter(UnityEngine.Collider other)
     {

    if (other.gameObject.tag == "Flechas")
    {
        GetHit1();
    }

    if (other.gameObject.tag == "Bdoor1")
    {
        SceneManager.LoadScene("Nivel 2");
    }

    if (other.gameObject.tag == "Bdoor2")
    {
        SceneManager.LoadScene("procLvl");
    }

    if (other.gameObject.tag == "Bdoor3")
    {
        SceneManager.LoadScene("credits");
    }

    if (other.gameObject.tag == "quesoP1")
    {
        SceneManager.LoadScene("Nivel 1");
    }


    if (other.gameObject.tag == "Trap1")
    {
       GetHit1();
    }

    if (other.gameObject.tag == "trap2")
    {
        GetHit2();
    }

    }

}
