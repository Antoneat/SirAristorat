using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[CreateAssetMenu(fileName = "Apple", menuName = "Inventory")]
public class Item :  ScriptableObject
{
    new public string name = "Apple";
   //public bool isDefault =false;

    public Sprite icon = null;
    

    public  void Use()
    {  
       Debug.Log("Used" + name);
    }
}
