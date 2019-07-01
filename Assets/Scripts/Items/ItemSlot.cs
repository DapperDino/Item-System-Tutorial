using DapperDino.Items.Inventories;
using System;

namespace DapperDino.Items
{
    [Serializable]
    public struct ItemSlot
    {
        public InventoryItem item;
        public int quantity;

        public ItemSlot(InventoryItem item, int quantity)
        {
            this.item = item;
            this.quantity = quantity;
        }

        public static bool operator ==(ItemSlot a, ItemSlot b) { return a.Equals(b); }

        public static bool operator !=(ItemSlot a, ItemSlot b) { return !a.Equals(b); }
    }
}
