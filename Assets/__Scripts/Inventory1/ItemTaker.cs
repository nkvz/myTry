using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemTaker : MonoBehaviour
{
    [SerializeField] Inventory itemToAdd;
    [SerializeField] InventoryRealise targetInventory;

    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            targetInventory.AddItem(itemToAdd);
        }
    }
}
