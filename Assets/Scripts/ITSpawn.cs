using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ITSpawn : MonoBehaviour
{
    public GameObject itemSp;
    //public int numItemsSp;

    public float itemXsp;
    public float itemYsp =0.5f;
    public float itemZsp;
    void Start()
    {
       /* for (int i = 0; i < numItemsSp; i++) //loop para spawnear el item las veces que diga el int
        {
           aqui pondria el SpItems(); 
        }*/

        SpItems();
    }

    void SpItems()
    {
        Vector3 randpos = new Vector3(Random.Range(-itemXsp, itemXsp), itemYsp, Random.Range(-itemZsp, itemZsp)) + transform.position;
        GameObject clone = Instantiate(itemSp, randpos, Quaternion.identity);
    }

    void Update()
    {
        
    }
}
