using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interruptor : MonoBehaviour
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
        if (other.gameObject.tag == "Player" || other.gameObject.tag == "ModelAtk" || other.gameObject.tag == "ModelEvade")
        {
            modCha.model1.SetActive(false);
            modCha.model2.SetActive(true);
            
        }
    }
}
