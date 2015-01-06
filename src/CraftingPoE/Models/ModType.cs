using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CraftingPoE.Models
{
    public class ModType
    {
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        public string Name { get; set; }

        public AffixType Type { get; set; }

        public List<Mod> Mods { get; set; } 
    }
}