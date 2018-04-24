namespace EShop.DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Relation_Favorite_Customer_Product : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Favorites", "Customer_CustomerId", c => c.Int());
            AddColumn("dbo.Favorites", "Product_ProductId", c => c.Int());
            CreateIndex("dbo.Favorites", "Customer_CustomerId");
            CreateIndex("dbo.Favorites", "Product_ProductId");
            AddForeignKey("dbo.Favorites", "Customer_CustomerId", "dbo.Customers", "CustomerId");
            AddForeignKey("dbo.Favorites", "Product_ProductId", "dbo.Products", "ProductId");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Favorites", "Product_ProductId", "dbo.Products");
            DropForeignKey("dbo.Favorites", "Customer_CustomerId", "dbo.Customers");
            DropIndex("dbo.Favorites", new[] { "Product_ProductId" });
            DropIndex("dbo.Favorites", new[] { "Customer_CustomerId" });
            DropColumn("dbo.Favorites", "Product_ProductId");
            DropColumn("dbo.Favorites", "Customer_CustomerId");
        }
    }
}
