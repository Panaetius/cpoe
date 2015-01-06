using CraftingPoE.Models;
using Microsoft.Data.Entity;
using Microsoft.Data.Entity.Metadata;
using Microsoft.Data.Entity.Migrations.Infrastructure;
using System;

namespace CraftingPoE.Migrations
{
    [ContextType(typeof(CraftingDbContext))]
    public partial class migration1 : IMigrationMetadata
    {
        string IMigrationMetadata.MigrationId
        {
            get
            {
                return "201501010207032_migration1";
            }
        }
        
        string IMigrationMetadata.ProductVersion
        {
            get
            {
                return "7.0.0-beta1-11518";
            }
        }
        
        IModel IMigrationMetadata.TargetModel
        {
            get
            {
                var builder = new BasicModelBuilder();
                
                builder.Entity("CraftingPoE.Models.ItemType", b =>
                    {
                        b.Property<int>("Id")
                            .GenerateValuesOnAdd();
                        b.Property<string>("Name");
                        b.Key("Id");
                    });
                
                builder.Entity("CraftingPoE.Models.ItemTypeToMod", b =>
                    {
                        b.Property<int>("Id")
                            .GenerateValuesOnAdd();
                        b.Property<int>("ItemTypeId");
                        b.Property<int>("ModId");
                        b.Key("Id");
                    });
                
                builder.Entity("CraftingPoE.Models.MasterMod", b =>
                    {
                        b.Property<AffixType>("AffixType");
                        b.Property<string>("Cost");
                        b.Property<int>("Id")
                            .GenerateValuesOnAdd();
                        b.Property<string>("Master");
                        b.Property<int>("MasterLevel");
                        b.Property<string>("Name");
                        b.Property<int>("PlayerLevel");
                        b.Key("Id");
                    });
                
                builder.Entity("CraftingPoE.Models.Mod", b =>
                    {
                        b.Property<int>("Id")
                            .GenerateValuesOnAdd();
                        b.Property<int>("Max");
                        b.Property<int>("Min");
                        b.Property<int>("MinLevel");
                        b.Property<int>("TypeId");
                        b.Key("Id");
                    });
                
                builder.Entity("CraftingPoE.Models.ModType", b =>
                    {
                        b.Property<int>("Id")
                            .GenerateValuesOnAdd();
                        b.Property<string>("Name");
                        b.Property<AffixType>("Type");
                        b.Key("Id");
                    });
                
                builder.Entity("CraftingPoE.Models.ItemTypeToMod", b =>
                    {
                        b.ForeignKey("CraftingPoE.Models.ItemType", "ItemTypeId");
                        b.ForeignKey("CraftingPoE.Models.Mod", "ModId");
                    });
                
                builder.Entity("CraftingPoE.Models.Mod", b =>
                    {
                        b.ForeignKey("CraftingPoE.Models.ModType", "TypeId");
                    });
                
                return builder.Model;
            }
        }
    }
}