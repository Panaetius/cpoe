using System;
using System.Linq;

namespace CraftingPoE.Models
{
    public class CraftingRepo : ICraftingRepo
    {
        private readonly CraftingDbContext _db;

        public CraftingRepo(CraftingDbContext db)
        {
            _db = db;
        }

        public EffectiveMod GetEffectiveMod(int modId)
        {
            return _db.EffectiveMods.FirstOrDefault(m => m.Id == modId);
        }
    }
}