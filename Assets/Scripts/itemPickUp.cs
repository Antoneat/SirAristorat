using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class itemPickUp : MonoBehaviour
{
    public Item item;
    //public Health hea;

    void Awake()
    {
       //GameObject Player = GameObject.FindGameObjectWithTag("Player");
       //hea = Player.GetComponent<Health>();
    }

    void Start()
    {
     
    }

    void PickUp()
    {
        Debug.Log("Picked up");
        bool wasPicked = inventory.instance.Add(item);

        if(wasPicked)
        {
            Destroy(gameObject);
        }
       
    }

    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "Player")
        {
            Debug.Log("pick up collision");
            PickUp();
        }
    }
 }
