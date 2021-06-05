using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trap1 : MonoBehaviour
{

    Rigidbody compRB;

    void Awake()
    {
        compRB = GetComponent<Rigidbody>();
    }
    void Start()
    {

    }


    void Update()
    {

    }

    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "Player")
        Destroy(gameObject);
    }
}
