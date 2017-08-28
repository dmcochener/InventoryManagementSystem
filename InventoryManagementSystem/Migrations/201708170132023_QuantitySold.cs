namespace InventoryManagementSystem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class QuantitySold : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.MenuItem", "QuantitySold", c => c.Int());
        }
        
        public override void Down()
        {
            DropColumn("dbo.MenuItem", "QuantitySold");
        }
    }
}
