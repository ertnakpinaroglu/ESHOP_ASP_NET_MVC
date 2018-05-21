namespace EShop.DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Create_Column_FKS_comment : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Comments", "Product_ProductId", "dbo.Products");
            DropForeignKey("dbo.Comments", "Customer_CustomerId", "dbo.Customers");
            DropIndex("dbo.Comments", new[] { "Customer_CustomerId" });
            DropIndex("dbo.Comments", new[] { "Product_ProductId" });
            RenameColumn(table: "dbo.Comments", name: "Product_ProductId", newName: "ProductId");
            RenameColumn(table: "dbo.Comments", name: "Customer_CustomerId", newName: "CustomerId");
            AlterColumn("dbo.Comments", "CustomerId", c => c.Int(nullable: false));
            AlterColumn("dbo.Comments", "ProductId", c => c.Int(nullable: false));
            CreateIndex("dbo.Comments", "ProductId");
            CreateIndex("dbo.Comments", "CustomerId");
            AddForeignKey("dbo.Comments", "ProductId", "dbo.Products", "ProductId", cascadeDelete: true);
            AddForeignKey("dbo.Comments", "CustomerId", "dbo.Customers", "CustomerId", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Comments", "CustomerId", "dbo.Customers");
            DropForeignKey("dbo.Comments", "ProductId", "dbo.Products");
            DropIndex("dbo.Comments", new[] { "CustomerId" });
            DropIndex("dbo.Comments", new[] { "ProductId" });
            AlterColumn("dbo.Comments", "ProductId", c => c.Int());
            AlterColumn("dbo.Comments", "CustomerId", c => c.Int());
            RenameColumn(table: "dbo.Comments", name: "CustomerId", newName: "Customer_CustomerId");
            RenameColumn(table: "dbo.Comments", name: "ProductId", newName: "Product_ProductId");
            CreateIndex("dbo.Comments", "Product_ProductId");
            CreateIndex("dbo.Comments", "Customer_CustomerId");
            AddForeignKey("dbo.Comments", "Customer_CustomerId", "dbo.Customers", "CustomerId");
            AddForeignKey("dbo.Comments", "Product_ProductId", "dbo.Products", "ProductId");
        }
    }
}
