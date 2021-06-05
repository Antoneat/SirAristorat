using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mouseMovOtro : MonoBehaviour
{
    public float depth;
    
    void Start()
    {

    }

    
    void Update()
    {
        Vector3 mousePos = Input.mousePosition;
        Vector3 wantedPos = Camera.main.ScreenToWorldPoint(new Vector3(mousePos.x, mousePos.y, depth));
        transform.position = wantedPos;
    }
}
