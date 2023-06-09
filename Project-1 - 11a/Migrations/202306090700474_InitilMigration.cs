namespace Project_1___11a.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitilMigration : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Products",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Brand = c.String(),
                        Description = c.String(),
                        Price = c.Decimal(nullable: false, precision: 18, scale: 2),
                        DateTime = c.Int(nullable: false),
                        ProductTypesId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.ProductTypes", t => t.ProductTypesId, cascadeDelete: true)
                .Index(t => t.ProductTypesId);
            
            CreateTable(
                "dbo.ProductTypes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        TypeName = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Products", "ProductTypesId", "dbo.ProductTypes");
            DropIndex("dbo.Products", new[] { "ProductTypesId" });
            DropTable("dbo.ProductTypes");
            DropTable("dbo.Products");
        }
    }
}
