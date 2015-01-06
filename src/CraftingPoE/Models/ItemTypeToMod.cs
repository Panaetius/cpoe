namespace CraftingPoE.Models
{
    public class ItemTypeToMod
    {
        public int Id { get; set; }

        public ItemType ItemType { get; set; } 

        public Mod Mod { get; set; }
    }
}