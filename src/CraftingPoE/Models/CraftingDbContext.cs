using Microsoft.Data.Entity;
using System;
using Microsoft.Data.Entity.Metadata;

namespace CraftingPoE.Models
{
    public class CraftingDbContext : DbContext
    {
        public DbSet<EffectiveMod> EffectiveMods { get; set; }

        protected override void OnConfiguring(DbContextOptions options)
        {
            options.UseSqlServer(Startup.Configuration.Get("Data:DefaultConnection:ConnectionString"));
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<EffectiveMod>().Key(e => e.Id);
            builder.Entity<EffectiveMod>().OneToMany<ActualMod>(e => e.ActualMods, a => a.LinkedMod).ForeignKey(a => a.EffectiveModId).Required();

            builder.Entity<ActualMod>().Key(a => a.Id);
            builder.Entity<ActualMod>().OneToMany(a => a.Brackets, b => b.Mod).ForeignKey(b => b.ModId);

            builder.Entity<Bracket>().Key(b => b.Id);

            builder.Entity<MasterMod>().Key(m => m.Id);

            base.OnModelCreating(builder);
        }
    }

    public class CraftingContextOptions : DbContextOptions
    {
    }
}