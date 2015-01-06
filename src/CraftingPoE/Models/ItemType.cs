using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CraftingPoE.Models
{
    public class ItemType
    {
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        public string Name { get; set; }

        public ItemType Parent { get; set; }

        public List<ItemTypeToMod> Mods { get; set; } 

        public List<MasterMod> MasterMods { get; set; } 
    }
}