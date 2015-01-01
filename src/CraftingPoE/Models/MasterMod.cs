using System;

namespace CraftingPoE.Models
{
    public class MasterMod
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public AffixType AffixType { get; set; }

        public ItemType ItemType { get; set; }

        public int MasterLevel { get; set; }

        public int PlayerLevel { get; set; }

        public string Cost { get; set; }

        public string Master { get; set; }
    }
}