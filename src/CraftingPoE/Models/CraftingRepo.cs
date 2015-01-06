using System;
using System.Collections.Generic;
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

        public ItemType GetItemType(int itemTypeId)
        {
            return _db.ItemTypes.FirstOrDefault(m => m.Id == itemTypeId);
        }

        public List<ItemType> GetItemTypes()
        {
            return _db.ItemTypes.ToList();
        }
    }

    public interface ICraftingRepo
    {
        ItemType GetItemType(int itemTypeId);
    }
}