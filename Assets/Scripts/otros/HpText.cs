using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HpText : MonoBehaviour
{
    public static int hpV;
    Text hp;


    void Start()
    {
        hpV = 3;
        hp = GetComponent<Text>();
    }


    void Update()
    {
        hp.text = "" + hpV;
    }
}
