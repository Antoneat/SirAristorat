using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyOneShoot : MonoBehaviour
{
    public Rigidbody rbd;
    public float speed;
    public float timer;
    public float MaxTimer;

    // Start is called before the first frame update
    void Start()
    {
        rbd = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        Move();
        Timer();
    }

    void Move()
    {
        rbd.velocity = new Vector2(speed, 0);
    }

    void Timer()
    {
        timer = timer + Time.deltaTime;
        if (timer >= MaxTimer)
        {
            Destroy(gameObject);
        }
    }

    
}