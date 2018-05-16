namespace EShop.DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateTable_Size : DbMigration
    {
        public override void Up()
        {
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
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Sizes", "Product_ProductId", "dbo.Products");
            DropIndex("dbo.Sizes", new[] { "Product_ProductId" });
            DropTable("dbo.Sizes");
        }
    }
}
