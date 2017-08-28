namespace InventoryManagementSystem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class WeeklyReport : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.WeeklyReport",
                c => new
                    {
                        DateOfReport = c.DateTime(nullable: false),
                        IngredientCost = c.Double(nullable: false),
                        Income = c.Double(nullable: false),
                        Profit = c.Double(nullable: false),
                    })
                .PrimaryKey(t => t.DateOfReport);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.WeeklyReport");
        }
    }
}
