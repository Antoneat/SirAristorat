using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using TMPro;

public class DmgNunInstance : MonoBehaviour
{
    public GameObject dmgText, enemyIns;
    public string TextDisplay;

    void Start()
    {
       
    }

    void Update()
    {
        //DmgNums();
    }

    public void DmgNums()
    {
        GameObject DmgTextInstance = Instantiate(dmgText, enemyIns.transform);
        DmgTextInstance.transform.GetChild(0).GetComponent<TextMeshPro>().SetText(TextDisplay);
    }
}
