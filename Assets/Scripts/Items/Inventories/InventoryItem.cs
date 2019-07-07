using DapperDino.Items.Hotbars;
using UnityEngine;

namespace DapperDino.Items.Inventories
{
    public abstract class InventoryItem : HotbarItem
    {
        [Header("Item Data")]
        [SerializeField] private Rarity rarity = null;
        [SerializeField] [Min(0)] private int sellPrice = 1;
        [SerializeField] [Min(1)] private int maxStack = 1;

        public override string ColouredName
        {
            get
            {
                string hexColour = ColorUtility.ToHtmlStringRGB(rarity.TextColour);
                return $"<color=#{hexColour}>{Name}</color>";
            }
        }
        public int SellPrice => sellPrice;
        public int MaxStack => maxStack;
        public Rarity Rarity => rarity;
    }
}
