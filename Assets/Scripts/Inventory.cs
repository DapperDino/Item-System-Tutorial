using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DapperDino.Items
{
    public class Inventory : ScriptableObject, IItemContainer
    {
        public ItemSlot AddItem(ItemSlot itemSlot)
        {
            throw new System.NotImplementedException();
        }

        public int GetTotalQuantity(InventoryItem item)
        {
            throw new System.NotImplementedException();
        }

        public bool HasItem(InventoryItem item)
        {
            throw new System.NotImplementedException();
        }

        public void RemoveAt(int slotIndex)
        {
            throw new System.NotImplementedException();
        }

        public void RemoveItem(ItemSlot itemSlot)
        {
            throw new System.NotImplementedException();
        }

        public void Swap(int indexOne, int indexTwo)
        {
            throw new System.NotImplementedException();
        }
    }
}
