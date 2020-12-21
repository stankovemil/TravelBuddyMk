namespace TravelBuddy.mk.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class img1 : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Cities", "imageUrl");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Cities", "imageUrl", c => c.String());
        }
    }
}
