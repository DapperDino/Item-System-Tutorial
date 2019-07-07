using UnityEngine;

namespace DapperDino.Items
{
    [CreateAssetMenu(fileName = "New Rarity", menuName = "Items/Rarity")]
    public class Rarity : ScriptableObject
    {
        [SerializeField] private new string name = "New Rarity Name";
        [SerializeField] private Color textColour = new Color(1f, 1f, 1f, 1f);

        public string Name => name;
        public Color TextColour => textColour;
    }
}
