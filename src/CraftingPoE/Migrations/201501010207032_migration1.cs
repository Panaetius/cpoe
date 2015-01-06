using Microsoft.Data.Entity.Migrations;
using Microsoft.Data.Entity.Migrations.Builders;
using Microsoft.Data.Entity.Relational.Model;
using System;

namespace CraftingPoE.Migrations
{
    public partial class migration1 : Migration
    {
        public override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable("ItemTypeToMod",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ItemTypeId = c.Int(nullable: false),
                        ModId = c.Int(nullable: false)
                    })
                .PrimaryKey("PK_ItemTypeToMod", t => t.Id);
            
            migrationBuilder.CreateTable("Mod",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Max = c.Int(nullable: false),
                        Min = c.Int(nullable: false),
                        MinLevel = c.Int(nullable: false),
                        TypeId = c.Int(nullable: false)
                    })
                .PrimaryKey("PK_Mod", t => t.Id);
            
            migrationBuilder.CreateTable("ModType",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Type = c.Int(nullable: false)
                    })
                .PrimaryKey("PK_ModType", t => t.Id);
            
            migrationBuilder.AddForeignKey("ItemTypeToMod", "FK_ItemTypeToMod_ItemType_ItemTypeId", new[] { "ItemTypeId" }, "ItemType", new[] { "Id" }, cascadeDelete: false);
            
            migrationBuilder.AddForeignKey("ItemTypeToMod", "FK_ItemTypeToMod_Mod_ModId", new[] { "ModId" }, "Mod", new[] { "Id" }, cascadeDelete: false);
            
            migrationBuilder.AddForeignKey("Mod", "FK_Mod_ModType_TypeId", new[] { "TypeId" }, "ModType", new[] { "Id" }, cascadeDelete: false);
        }
        
        public override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable("ItemTypeToMod");
            
            migrationBuilder.DropTable("Mod");
            
            migrationBuilder.DropTable("ModType");
        }
    }
}