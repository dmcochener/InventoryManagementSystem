namespace InventoryManagementSystem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updatedextraclass : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Extra", "Extra_ExtraId", "dbo.Extra");
            DropIndex("dbo.Extra", new[] { "Extra_ExtraId" });
            DropColumn("dbo.Extra", "Extra_ExtraId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Extra", "Extra_ExtraId", c => c.Guid());
            CreateIndex("dbo.Extra", "Extra_ExtraId");
            AddForeignKey("dbo.Extra", "Extra_ExtraId", "dbo.Extra", "ExtraId");
        }
    }
}
