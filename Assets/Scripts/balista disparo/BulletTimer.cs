using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletTimer : MonoBehaviour
{
    public float timer;
    public float MaxTimer;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        Timer();
    }

    void Timer()
    {
        timer = timer + Time.deltaTime;
        if (timer >= MaxTimer)
        {
            Destroy(gameObject);
        }
    }

    void OnTriggerEnter(UnityEngine.Collider other)
    {

        if (other.gameObject.tag == "wall")
        {
            Destroy(gameObject);
        }
    }
}