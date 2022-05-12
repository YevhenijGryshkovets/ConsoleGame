namespace EntitiesCodeFirstMethod.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Armors",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        ArmorType_Id = c.Int(),
                        Player_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.ArmorTypes", t => t.ArmorType_Id)
                .ForeignKey("dbo.Players", t => t.Player_Id)
                .Index(t => t.ArmorType_Id)
                .Index(t => t.Player_Id);
            
            CreateTable(
                "dbo.ArmorTypes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        ArmorId = c.Int(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Players",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        WeaponId = c.Int(),
                        ArmorId = c.Int(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Weapons",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Player_Id = c.Int(),
                        WeaponType_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Players", t => t.Player_Id)
                .ForeignKey("dbo.WeaponTypes", t => t.WeaponType_Id)
                .Index(t => t.Player_Id)
                .Index(t => t.WeaponType_Id);
            
            CreateTable(
                "dbo.WeaponTypes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        WeaponId = c.Int(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Weapons", "WeaponType_Id", "dbo.WeaponTypes");
            DropForeignKey("dbo.Weapons", "Player_Id", "dbo.Players");
            DropForeignKey("dbo.Armors", "Player_Id", "dbo.Players");
            DropForeignKey("dbo.Armors", "ArmorType_Id", "dbo.ArmorTypes");
            DropIndex("dbo.Weapons", new[] { "WeaponType_Id" });
            DropIndex("dbo.Weapons", new[] { "Player_Id" });
            DropIndex("dbo.Armors", new[] { "Player_Id" });
            DropIndex("dbo.Armors", new[] { "ArmorType_Id" });
            DropTable("dbo.WeaponTypes");
            DropTable("dbo.Weapons");
            DropTable("dbo.Players");
            DropTable("dbo.ArmorTypes");
            DropTable("dbo.Armors");
        }
    }
}
