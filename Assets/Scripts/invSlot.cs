using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class invSlot : MonoBehaviour
{
    Item item;
    public Image icon;
    public void AddItem(Item newItem)
    {
        item = newItem;
        icon.sprite = item.icon;
        icon.enabled = true;
    }

    public void ClearSlot()
    {
        item = null;
        icon.sprite = null;
        icon.enabled = false;
    }

    public void UseItem()
    {
        if(item!=null)
        {
            item.Use();
        }
    }

    public void Removed()
    {
        inventory.instance.Remove(item);
    }
}
