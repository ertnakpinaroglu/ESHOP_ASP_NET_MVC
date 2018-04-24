namespace EShop.DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Relation_Sale_Product_Customer : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Sales", "ProductId", c => c.Int(nullable: false));
            AddColumn("dbo.Sales", "CustomerId", c => c.Int(nullable: false));
            CreateIndex("dbo.Sales", "ProductId");
            CreateIndex("dbo.Sales", "CustomerId");
            AddForeignKey("dbo.Sales", "CustomerId", "dbo.Customers", "CustomerId", cascadeDelete: true);
            AddForeignKey("dbo.Sales", "ProductId", "dbo.Products", "ProductId", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Sales", "ProductId", "dbo.Products");
            DropForeignKey("dbo.Sales", "CustomerId", "dbo.Customers");
            DropIndex("dbo.Sales", new[] { "CustomerId" });
            DropIndex("dbo.Sales", new[] { "ProductId" });
            DropColumn("dbo.Sales", "CustomerId");
            DropColumn("dbo.Sales", "ProductId");
        }
    }
}
