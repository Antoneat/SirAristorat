using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAutoShoot : MonoBehaviour
{
    
    public GameObject EnemyOneBullet;
     public Transform barrel;

    public float shootrate;
    float nextshoot;

    // Use this for initialization
    void Start()
    {
        nextshoot= Time.time;
    }

    // Update is called once per frame
    void Update()
    {
        CheckIfTimeToShoot();
    }

    void CheckIfTimeToShoot()
    {
        if (Time.time > nextshoot)
        {
            Instantiate(EnemyOneBullet, barrel.position, Quaternion.identity);
            nextshoot = Time.time + shootrate;
        }

    }
}