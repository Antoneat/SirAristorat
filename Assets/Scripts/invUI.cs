using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class invUI : MonoBehaviour
{
    public Transform itemsParent;
    inventory inv;
    invSlot[] slots; 

    void Start()
    {
        inv = inventory.instance;
        inv.onItemChangedCallback += updateUI;
        slots = itemsParent.GetComponentsInChildren<invSlot>();
    }

    // Update is called once per frame
    void Update()
    {
        for (int i = 0; i < slots.Length; i++)
        {
            if(i < inv.items.Count)
            {
                slots[i].AddItem(inv.items[i]);
            }
            else
            {
                slots[i].ClearSlot();
            }
        }
    }

    void updateUI()
    {
        Debug.Log("Updating UI");
    }
}
