using CraftingPoE.Models;
using Microsoft.Data.Entity;
using Microsoft.Data.Entity.Metadata;
using Microsoft.Data.Entity.Migrations.Infrastructure;
using System;

namespace CraftingPoE.Migrations
{
    [ContextType(typeof(CraftingDbContext))]
    public partial class initial : IMigrationMetadata
    {
        string IMigrationMetadata.MigrationId
        {
            get
            {
                return "201501010150369_initial";
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
                
                return builder.Model;
            }
        }
    }
}