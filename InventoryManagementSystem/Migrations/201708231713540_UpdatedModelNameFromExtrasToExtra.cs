namespace InventoryManagementSystem.Migrations
{
    using System.Data.Entity.Migrations;

    public partial class UpdatedModelNameFromExtrasToExtra : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Extra",
                c => new
                    {
                        ExtraId = c.Guid(nullable: false, identity: true),
                        Name = c.String(),
                        Cost = c.Double(nullable: false),
                    })
                .PrimaryKey(t => t.ExtraId);
        }
        
        public override void Down()
        {
            DropTable("dbo.Extra");
        }
    }
}
