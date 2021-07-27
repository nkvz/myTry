using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "ItemData", menuName = "Inventory/Item")]

public class Inventory : ScriptableObject
{
    [Header("Set In Inspector")]
    public string Name = "Item";
    public Sprite Icon;
    public int num;
}
