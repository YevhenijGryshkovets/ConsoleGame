namespace EntitiesCodeFirstMethod.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class thirdTry : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.ArmorTypes", "ArmorId");
            DropColumn("dbo.WeaponTypes", "WeaponId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.WeaponTypes", "WeaponId", c => c.Int());
            AddColumn("dbo.ArmorTypes", "ArmorId", c => c.Int());
        }
    }
}
