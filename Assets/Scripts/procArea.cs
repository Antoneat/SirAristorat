using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class procArea : MonoBehaviour
{
    public GameObject area;

    bool taken1 = false;
    bool taken2 = false;
    bool taken3 = false;
    bool taken4 = false;

    void Start()
    {
        if(taken1==false)
        {
            AreaSP1();
        }

        if (taken2 == false)
        {
            AreaSP2();
        }

        if (taken3 == false)
        {
            AreaSP3();
        }

        if (taken4 == false)
        {
            AreaSP4();
        }
    }

    void Update()
    {

    }

    void AreaSP1()
    {
        Vector3 a1 = new Vector3(0f,0f,44.4f);
        GameObject clone = Instantiate(area, a1, Quaternion.identity);
        taken1 = true;
    }

    void AreaSP2()
    {
        Vector3 a2 = new Vector3(0f, 0f, 4.43f);
        GameObject clone = Instantiate(area, a2, Quaternion.identity);
        taken2 = true;
    }

    void AreaSP3()
    {
        Vector3 a3 = new Vector3(-28.48f,0,35.56f);
        
        GameObject clone = Instantiate(area, a3, Quaternion.AngleAxis(90, Vector3.up));
        
        taken3 = true;
    }

    void AreaSP4()
    {
        Vector3 a4 = new Vector3(11.46f,0,35.56f);
        GameObject clone = Instantiate(area, a4, Quaternion.AngleAxis(90, Vector3.up));
        taken4 = true;
    }

}