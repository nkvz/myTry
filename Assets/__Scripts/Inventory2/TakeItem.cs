using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class TakeItem : MonoBehaviour
{
    [Header("Set In Inspector")]
    private Invent inventory;
    public GameObject slotButton;

    public void Start()
    {
        inventory = GameObject.FindGameObjectWithTag("Player").GetComponent<Invent>();

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            for (int i = 0; i < inventory.slots.Length; i++)
            {
                if(inventory.isFull[i] == false)
                {
                    inventory.isFull[i] = true;
                    Instantiate(slotButton, inventory.slots[i].transform);
                    Destroy(gameObject);
                    break;
                }
            }
        }
    }
}
