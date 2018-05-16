namespace EShop.DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Create_table_color : DbMigration
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
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Colors", "Product_ProductId", "dbo.Products");
            DropIndex("dbo.Colors", new[] { "Product_ProductId" });
            DropTable("dbo.Colors");
        }
    }
}
