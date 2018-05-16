namespace EShop.DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Create_Table_Color : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Colors",
                c => new
                {
                    SizeId = c.Int(nullable: false, identity: true),
                    SizeName = c.String(),
                    CreatedDate = c.DateTime(),
                    ModifiedDate = c.DateTime(),
                    RemovedDate = c.DateTime(),
                    Product_ProductId = c.Int(),
                })
                .PrimaryKey(t => t.SizeId);

            CreateIndex("dbo.Colors", "Product_ProductId");
            AddForeignKey("dbo.Colors", "Product_ProductId", "dbo.Products", "ProductId");
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Colors", "Product_ProductId", "dbo.Products");
            DropIndex("dbo.Sizes", new[] { "Product_ProductId" });
            DropTable("dbo.Sizes");
        }
    }
}
