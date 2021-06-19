using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interruptor1 : MonoBehaviour
{
    //public BoxCollider boxC;
    modelChange modCha;
    
    void Start()
    {
        modCha = GetComponent<modelChange>();
    }

 
    void Update()
    {
        
    }

    void OnTriggerEnter(UnityEngine.Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            modCha.model1.SetActive(false);
            modCha.model2.SetActive(true);
            //boxC.size = new Vector3(6, 4, 2);
            //boxC.center= new Vector3(0, 0.25f, 0); //box collider se hace de la mitad del size, cambia size en y
        }
    }
}
