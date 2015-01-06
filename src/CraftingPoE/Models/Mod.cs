using System.Collections.Generic;

namespace CraftingPoE.Models
{
    public class Mod
    {
        public int Id { get; set; } 

        public ModType Type { get; set; }

        public int Min { get; set; }

        public int Max { get; set; }

        public int MinLevel { get; set; }

        public List<ItemTypeToMod> ItemTypes { get; set; } 
    }
}