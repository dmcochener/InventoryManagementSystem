namespace InventoryManagementSystem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class WeeklyReport : DbMigration
    {
        public override void Up()
        {
            DropPrimaryKey("dbo.SoldItem");
            DropPrimaryKey("dbo.UsedIngredient");
            AlterColumn("dbo.SoldItem", "Index", c => c.Guid(nullable: false));
            AlterColumn("dbo.UsedIngredient", "Index", c => c.Guid(nullable: false));
            AddPrimaryKey("dbo.SoldItem", "Index");
            AddPrimaryKey("dbo.UsedIngredient", "Index");
        }
        
        public override void Down()
        {
            DropPrimaryKey("dbo.UsedIngredient");
            DropPrimaryKey("dbo.SoldItem");
            AlterColumn("dbo.UsedIngredient", "Index", c => c.Guid(nullable: false, identity: true));
            AlterColumn("dbo.SoldItem", "Index", c => c.Guid(nullable: false, identity: true));
            AddPrimaryKey("dbo.UsedIngredient", "Index");
            AddPrimaryKey("dbo.SoldItem", "Index");
        }
    }
}
