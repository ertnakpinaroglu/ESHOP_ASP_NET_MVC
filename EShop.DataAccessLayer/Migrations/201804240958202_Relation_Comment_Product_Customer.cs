namespace EShop.DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Relation_Comment_Product_Customer : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Comments", "Customer_CustomerId", c => c.Int());
            AddColumn("dbo.Comments", "Product_ProductId", c => c.Int());
            CreateIndex("dbo.Comments", "Customer_CustomerId");
            CreateIndex("dbo.Comments", "Product_ProductId");
            AddForeignKey("dbo.Comments", "Customer_CustomerId", "dbo.Customers", "CustomerId");
            AddForeignKey("dbo.Comments", "Product_ProductId", "dbo.Products", "ProductId");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Comments", "Product_ProductId", "dbo.Products");
            DropForeignKey("dbo.Comments", "Customer_CustomerId", "dbo.Customers");
            DropIndex("dbo.Comments", new[] { "Product_ProductId" });
            DropIndex("dbo.Comments", new[] { "Customer_CustomerId" });
            DropColumn("dbo.Comments", "Product_ProductId");
            DropColumn("dbo.Comments", "Customer_CustomerId");
        }
    }
}
