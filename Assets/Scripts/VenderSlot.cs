using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.EventSystems;

public class VenderSlot : Slot
{
    public override void OnPointerDown(PointerEventData eventData)
    {
        if(eventData.button == PointerEventData.InputButton.Right && InventoryManager.Instance.IsPickedItem==false)
        {
            if (transform.childCount > 0)
            {
                Item currentItem = transform.GetChild(0).GetComponent<ItemUI>().Item;
                transform.parent.parent.SendMessage("BuyItem", currentItem);
            }
        }
        else if(eventData.button == PointerEventData.InputButton.Left && InventoryManager.Instance.IsPickedItem)
        {
            transform.parent.parent.SendMessage("SellItem");
        }
    }
}
