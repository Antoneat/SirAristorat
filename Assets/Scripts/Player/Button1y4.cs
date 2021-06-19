using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Button1y4 : MonoBehaviour
{
    [SerializeField]
    public GameObject wep;

    public BoxCollider boxC;  
    public bool sword;
    public bool evading;

    modelChange modCha;
    pickBox pick;


    void Start()
    {
        sword = false;
        evading = false;

        boxC= GetComponent<BoxCollider>();
        modCha = GetComponent<modelChange>();
      
    }

    void Update()
    {
        Attack();
    }

    public void Attack()
    {
        if (sword == false)
        {
            wep.SetActive(false);
        }
        if (sword == true)
        {
            wep.SetActive(true);
        }


        if (Input.GetKeyDown(KeyCode.Alpha1) && sword == false)
        {
            sword = true;
            evading = false;

           // boxC.size = new Vector3(1, 1, 1);
            //boxC.center = new Vector3(0, 0, 0); //box collider se hace de la mitad del size, cambia size en y

            modCha.model1.SetActive(true);   
            modCha.model2.SetActive(false);

            Debug.Log("atac");
            
        }

        if (Input.GetKeyDown(KeyCode.Alpha4))
        {
           
            sword = false;
            evading = true;

            //boxC.size = new Vector3(1, 0.35f, 1);
            // boxC.center= new Vector3(0, 0.25f, 0); //box collider se hace de la mitad del size, cambia size en y

            modCha.model1.SetActive(false);
            modCha.model2.SetActive(true);

            Debug.Log("evade");
        }
    }


}