using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Piece : MonoBehaviour {

    [SerializeField]
    private Transform outPoint;

    public Vector3 outPosition {
        get {
            return outPoint.position;
        }
    }

    public Vector3 outDirection {
        get {
            return outPoint.forward;
        }
    }


}
