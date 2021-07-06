using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class procRooms : MonoBehaviour
{
    //public GameObject room1;
    //public GameObject room2;
    //public GameObject room3;
    //public GameObject room4;

    bool taken1 = false;
    bool taken2 = false;
    bool taken3 = false;
    bool taken4 = false;

    public GameObject[] myRooms;

 
    void Start()
    {

        if (taken1 == false)
        {
            AreaSP1();
            AreaSP2();
            AreaSP3();
            AreaSP4();
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
        Vector3 a1 = new Vector3(0f, 0f, 0);

        int randomIndex = Random.Range(0, myRooms.Length);
        GameObject clone = Instantiate(myRooms[randomIndex], a1, Quaternion.identity) as GameObject;

        //GameObject clone = Instantiate(room1, a1, Quaternion.identity);
        taken1 = true;
    }

    void AreaSP2()
    {
        Vector3 a2 = new Vector3(0f, 0f, 0);

        int randomIndex = Random.Range(0, myRooms.Length);
        GameObject clone = Instantiate(myRooms[randomIndex], a2, Quaternion.identity) as GameObject;

        //GameObject clone = Instantiate(room2, a2, Quaternion.identity);
        taken2 = true;
    }

    void AreaSP3()
    {
        Vector3 a3 = new Vector3(0, 0, 0);


        int randomIndex = Random.Range(0, myRooms.Length);
        GameObject clone = Instantiate(myRooms[randomIndex], a3, Quaternion.identity) as GameObject;

        //GameObject clone = Instantiate(room3, a3, Quaternion.AngleAxis(90, Vector3.up));

        taken3 = true;
    }

    void AreaSP4()
    {
        Vector3 a4 = new Vector3(0, 0, 0);


        int randomIndex = Random.Range(0, myRooms.Length);
        GameObject clone = Instantiate(myRooms[randomIndex], a4, Quaternion.identity) as GameObject;

        //GameObject clone = Instantiate(room4, a4, Quaternion.AngleAxis(90, Vector3.up));
        taken4 = true;
    }

}