namespace Agora.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddProductAvailabilityModel : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ProductAvailabilities",
                c => new
                    {
                        AvailabilityId = c.Int(nullable: false, identity: true),
                        AvailabilityType = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.AvailabilityId);
            
            AddColumn("dbo.Products", "Availability", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Products", "Availability");
            DropTable("dbo.ProductAvailabilities");
        }
    }
}
