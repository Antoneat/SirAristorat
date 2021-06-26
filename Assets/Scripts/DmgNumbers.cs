using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DmgNumbers : MonoBehaviour
{
    public void DestroyDad()
    {
        GameObject parent = gameObject.transform.parent.gameObject;
        Destroy(parent);

    }

}
