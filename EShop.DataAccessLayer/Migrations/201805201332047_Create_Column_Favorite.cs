namespace EShop.DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Create_Column_Favorite : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Favorites", "Product_ProductId", "dbo.Products");
            DropForeignKey("dbo.Favorites", "Customer_CustomerId", "dbo.Customers");
            DropIndex("dbo.Favorites", new[] { "Customer_CustomerId" });
            DropIndex("dbo.Favorites", new[] { "Product_ProductId" });
            RenameColumn(table: "dbo.Favorites", name: "Product_ProductId", newName: "ProductId");
            RenameColumn(table: "dbo.Favorites", name: "Customer_CustomerId", newName: "CustomerId");
            AlterColumn("dbo.Favorites", "CustomerId", c => c.Int(nullable: false));
            AlterColumn("dbo.Favorites", "ProductId", c => c.Int(nullable: false));
            CreateIndex("dbo.Favorites", "ProductId");
            CreateIndex("dbo.Favorites", "CustomerId");
            AddForeignKey("dbo.Favorites", "ProductId", "dbo.Products", "ProductId", cascadeDelete: true);
            AddForeignKey("dbo.Favorites", "CustomerId", "dbo.Customers", "CustomerId", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Favorites", "CustomerId", "dbo.Customers");
            DropForeignKey("dbo.Favorites", "ProductId", "dbo.Products");
            DropIndex("dbo.Favorites", new[] { "CustomerId" });
            DropIndex("dbo.Favorites", new[] { "ProductId" });
            AlterColumn("dbo.Favorites", "ProductId", c => c.Int());
            AlterColumn("dbo.Favorites", "CustomerId", c => c.Int());
            RenameColumn(table: "dbo.Favorites", name: "CustomerId", newName: "Customer_CustomerId");
            RenameColumn(table: "dbo.Favorites", name: "ProductId", newName: "Product_ProductId");
            CreateIndex("dbo.Favorites", "Product_ProductId");
            CreateIndex("dbo.Favorites", "Customer_CustomerId");
            AddForeignKey("dbo.Favorites", "Customer_CustomerId", "dbo.Customers", "CustomerId");
            AddForeignKey("dbo.Favorites", "Product_ProductId", "dbo.Products", "ProductId");
        }
    }
}
