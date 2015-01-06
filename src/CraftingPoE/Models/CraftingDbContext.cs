using Microsoft.Data.Entity;
using System;
using Microsoft.Data.Entity.Metadata;

namespace CraftingPoE.Models
{
    public class CraftingDbContext : DbContext
    {
        public DbSet<ItemType> ItemTypes { get; set; } 
        protected override void OnConfiguring(DbContextOptions options)
        {
            options.UseSqlServer(Startup.Configuration.Get("Data:DefaultConnection:ConnectionString"));
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<ItemType>().Key(i => i.Id);
            builder.Entity<ItemType>().OneToMany(i => i.Mods, i => i.ItemType);

            builder.Entity<Mod>().Key(m => m.Id);
            builder.Entity<Mod>().OneToMany(m => m.ItemTypes, m => m.Mod);
            builder.Entity<Mod>().ManyToOne(m => m.Type, m => m.Mods);

            builder.Entity<ItemTypeToMod>().Key(i => i.Id);

            builder.Entity<ModType>().Key(m => m.Id);
            builder.Entity<MasterMod>().Key(m => m.Id);

            base.OnModelCreating(builder);
        }
    }

    public class CraftingContextOptions : DbContextOptions
    {
    }
}