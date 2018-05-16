namespace EShop.DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Create_Table_Color_Size : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Colors",
                c => new
                    {
                        ColorId = c.Int(nullable: false, identity: true),
                        ColorName = c.String(),
                        CreatedDate = c.DateTime(),
                        ModifiedDate = c.DateTime(),
                        RemovedDate = c.DateTime(),
                        Product_ProductId = c.Int(),
                    })
                .PrimaryKey(t => t.ColorId)
                .ForeignKey("dbo.Products", t => t.Product_ProductId)
                .Index(t => t.Product_ProductId);
            
            CreateTable(
                "dbo.Sizes",
                c => new
                    {
                        SizeId = c.Int(nullable: false, identity: true),
                        SizeName = c.String(),
                        CreatedDate = c.DateTime(),
                        ModifiedDate = c.DateTime(),
                        RemovedDate = c.DateTime(),
                        Product_ProductId = c.Int(),
                    })
                .PrimaryKey(t => t.SizeId)
                .ForeignKey("dbo.Products", t => t.Product_ProductId)
                .Index(t => t.Product_ProductId);
            
            DropColumn("dbo.Products", "Color");
            DropColumn("dbo.Products", "Size");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Products", "Size", c => c.String());
            AddColumn("dbo.Products", "Color", c => c.String());
            DropForeignKey("dbo.Sizes", "Product_ProductId", "dbo.Products");
            DropForeignKey("dbo.Colors", "Product_ProductId", "dbo.Products");
            DropIndex("dbo.Sizes", new[] { "Product_ProductId" });
            DropIndex("dbo.Colors", new[] { "Product_ProductId" });
            DropTable("dbo.Sizes");
            DropTable("dbo.Colors");
        }
    }
}
