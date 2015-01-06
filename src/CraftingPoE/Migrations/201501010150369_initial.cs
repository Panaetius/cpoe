using Microsoft.Data.Entity.Migrations;
using Microsoft.Data.Entity.Migrations.Builders;
using Microsoft.Data.Entity.Relational.Model;
using System;

namespace CraftingPoE.Migrations
{
    public partial class initial : Migration
    {
        public override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable("ItemType",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String()
                    })
                .PrimaryKey("PK_ItemType", t => t.Id);
            
            migrationBuilder.CreateTable("MasterMod",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        AffixType = c.Int(nullable: false),
                        Cost = c.String(),
                        Master = c.String(),
                        MasterLevel = c.Int(nullable: false),
                        Name = c.String(),
                        PlayerLevel = c.Int(nullable: false)
                    })
                .PrimaryKey("PK_MasterMod", t => t.Id);
        }
        
        public override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable("ItemType");
            
            migrationBuilder.DropTable("MasterMod");
        }
    }
}