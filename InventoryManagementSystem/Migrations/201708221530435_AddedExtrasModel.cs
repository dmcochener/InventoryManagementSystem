namespace InventoryManagementSystem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedExtrasModel : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Extra",
                c => new
                    {
                        ExtrasId = c.Guid(nullable: false, identity: true),
                        Name = c.String(),
                        Cost = c.Double(nullable: false),
                    })
                .PrimaryKey(t => t.ExtrasId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Extras");
        }
    }
}
