using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InventoryWindow : MonoBehaviour
{
    [SerializeField] InventoryRealise targetInventory;
    [SerializeField] RectTransform itemsPanel;

    List<GameObject> drawIcons = new List<GameObject>();
    public void Start()
    {
        targetInventory.onItemAdded += OnItemAdded;
        Redraw();
    }

    void OnItemAdded(Inventory obj) => Redraw(); 


    public void Redraw()
    {
        ClearDraw();

        for (var i = 0; i < targetInventory.InventoryItems.Count; i++)
        {
            var item = targetInventory.InventoryItems[i];

            var icon = new GameObject(name: "Icon");
            icon.AddComponent<Image>().sprite = item.Icon;
            icon.transform.SetParent(itemsPanel);

            drawIcons.Add(icon);
        }

        void ClearDraw()
        {
            for(var i = 0; i<drawIcons.Count; i++)
            {
                Destroy(drawIcons[i]);
                drawIcons.Clear();
            }
        }
    }
}
