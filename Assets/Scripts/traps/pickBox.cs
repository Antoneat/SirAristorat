using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pickBox : MonoBehaviour
{
    public Transform dest;
    public bool carrying;
    public float range;
    public float throwForce;

    public modelChange modCha;
    public Button1y4 butt;

    void Awake()
    {
        
    }

    void Start()
    {
        GameObject Player = GameObject.FindGameObjectWithTag("Player");
        modCha = Player.GetComponent<modelChange>();
        butt = Player.GetComponent<Button1y4>();

        carrying = false;
    }

    void Update()
    {
        {
            if (carrying == false)
            {
                if (Input.GetKeyDown(KeyCode.Alpha2) && butt.evading == false && (dest.transform.position - transform.position).sqrMagnitude < range / range )
                {
                    OnThree();
                    carrying = true;
                    butt.evading = false;


                    modCha.model1.SetActive(true);
                    modCha.model2.SetActive(false); 
                }
            }
            else if (carrying == true && butt.evading == false)
            {
                if (Input.GetKeyDown(KeyCode.Alpha3))
                {
                    OnFour();
                    carrying = false;
                    butt.evading = false;

                    modCha.model1.SetActive(true);
                    modCha.model2.SetActive(false);
                }
            }
        }
    }

    void OnThree()
    {
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            GetComponent<Rigidbody>().useGravity = false;
            GetComponent<Rigidbody>().freezeRotation = true;
            GetComponent<Rigidbody>().isKinematic = true;
            this.transform.position = dest.position;
            this.transform.parent = GameObject.Find("destination").transform;
        }
    }

    // Update is called once per frame
    void OnFour()
    {
        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            this.transform.parent = null;
            GetComponent<Rigidbody>().useGravity = true;
            GetComponent<BoxCollider>().enabled = true;
            GetComponent<Rigidbody>().freezeRotation = false;
            GetComponent<Rigidbody>().isKinematic = false;
            GetComponent<Rigidbody>().AddForce(dest.transform.forward * throwForce);
        }
    }
}
