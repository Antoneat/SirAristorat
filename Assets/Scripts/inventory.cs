using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class inventory : MonoBehaviour
{
    public delegate void OnItemChanged();
    public OnItemChanged onItemChangedCallback;
    public int space = 1;
    public static inventory instance;
    public List<Item> items = new List<Item>();

    Health hea;
    public invSlot invS;

    void Awake()
    {
        hea = GetComponent<Health>();
        GameObject Panel = GameObject.FindGameObjectWithTag("panel");
        invS = Panel.GetComponent<invSlot>();
        //invS = GetComponent<invSlot>();

        if (instance!= null)
        {
            Debug.LogWarning("more than one inventory instance");
        }

        instance = this;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha5) && hea.hp <= 2)
        {
            UseApple();
            invS.Removed();
        }

    }

    void UseApple()
    {
        hea.GetHeal();
   

    }

    public bool Add(Item item)
    {
        if(items.Count >= space)
        {
            Debug.Log("out of space");
            return false;
        }

        items.Add(item);

        if(onItemChangedCallback !=null)
        { 
            onItemChangedCallback.Invoke(); 
        }
        

        return true;
    }


    public void Remove(Item item)
    {
        items.Remove(item);
        if (onItemChangedCallback != null)
        {
         onItemChangedCallback.Invoke();
        }
        
    }
}
