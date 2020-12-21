namespace TravelBuddy.mk.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class img2 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Cities", "img1", c => c.String(nullable: false));
            AddColumn("dbo.Cities", "img2", c => c.String(nullable: false));
            AddColumn("dbo.Cities", "img3", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Cities", "img3");
            DropColumn("dbo.Cities", "img2");
            DropColumn("dbo.Cities", "img1");
        }
    }
}
