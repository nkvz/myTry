using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class InventoryRealise : MonoBehaviour
{
    public Action<Inventory> onItemAdded;

    [SerializeField] List<Inventory> StartItems = new List<Inventory>();

    public List<Inventory> InventoryItems = new List<Inventory>();

    public void Start()
    {
        for (var i = 0; i<StartItems.Count; i++)
        {
            AddItem(StartItems[i]);
        }
    }

    public void AddItem(Inventory item)
    {
        InventoryItems.Add(item);

        onItemAdded?.Invoke(item);
    }
}
