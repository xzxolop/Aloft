using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DemoScript : MonoBehaviour
{
    public InventoryManager inventoryManager;
    public Item itemsFir;


    public void PickupItem() 
    {

        bool result = inventoryManager.AddItem(itemsFir);
        if (result == true) Debug.Log("Item added");
        else
            Debug.Log("Not Added");

    }
}
