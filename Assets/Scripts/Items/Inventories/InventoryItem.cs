using UnityEngine;

namespace DapperDino.Items.Inventories
{
    public abstract class InventoryItem : HotbarItem
    {
        [Header("Item Data")]
        [SerializeField] [Min(0)] private int sellPrice = 1;
        [SerializeField] [Min(1)] private int maxStack = 1;

        public override string ColouredName
        {
            get
            {
                return Name;
            }
        }
        public int SellPrice => sellPrice;
        public int MaxStack => maxStack;
    }
}
