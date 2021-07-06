using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TutoRes : MonoBehaviour
{
    Enemy1Health ee;
  
    public GameObject model1;
    public GameObject model2;

    void Start()
    {
        GameObject enemy1 = GameObject.FindGameObjectWithTag("enemy1");
        ee = enemy1.GetComponent<Enemy1Health>();
        model1.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        Unlock();
    }

    void Unlock()
    {
        if (ee.hp<=0)
        {
            model1.SetActive(false);
            model2.SetActive(true);

        }
    }
}
