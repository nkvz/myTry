using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Slot : MonoBehaviour
{
    [Header("Set In Inspector")]
    private Invent inventory;
    public int i;

    public void Start()
    {
        inventory = GameObject.FindGameObjectWithTag("Player").GetComponent<Invent>();
    }

    private void Update()
    {
        if(transform.childCount <= 0)
        {
            inventory.isFull[i] = false;
        }

    }

    public void DropItem()
    {
        foreach (Transform child in transform)
        {
            child.GetComponent<Drops>().SpawnDroppedItem();
            GameObject.Destroy(child.gameObject);
        }
    }
}
