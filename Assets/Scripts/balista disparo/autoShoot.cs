using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class autoShoot : MonoBehaviour
{ 
    public Transform player;
    public float range = 50.0f;
    public float bulletImpulse = 20.0f;

    private bool onRange = false;

    public Rigidbody projectile;

    public float timer;
    public float MaxTimer;

    void Start()
    {
        //float rand = Random.Range(1.0f, 2.0f);
        //InvokeRepeating("Shoot", 2, rand);
    }


    void Update()
    {

        onRange = Vector3.Distance(transform.position, player.position) < range;

        if (onRange)
        {
            //transform.LookAt(player);
        }
        Shoot();
    }


    public void Shoot()
    {
        timer = timer + Time.deltaTime;
        if (timer >= MaxTimer)
        {
            Rigidbody bullet = (Rigidbody)Instantiate(projectile, transform.position + transform.forward, transform.rotation);
            bullet.AddForce(transform.forward * bulletImpulse, ForceMode.Impulse);
            timer = 0;
            //Destroy(bullet.gameObject, 2);
        }
    }

}