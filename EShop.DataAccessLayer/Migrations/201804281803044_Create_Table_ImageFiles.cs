namespace EShop.DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Create_Table_ImageFiles : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ImageFiles",
                c => new
                    {
                        ImagesFileId = c.Int(nullable: false, identity: true),
                        ProfileImage = c.String(),
                        ProductId = c.Int(nullable: false),
                        CreatedDate = c.DateTime(),
                        ModifiedDate = c.DateTime(),
                        RemovedDate = c.DateTime(),
                    })
                .PrimaryKey(t => t.ImagesFileId)
                .ForeignKey("dbo.Products", t => t.ProductId, cascadeDelete: true)
                .Index(t => t.ProductId);
            
            DropColumn("dbo.Products", "ProfileImage");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Products", "ProfileImage", c => c.String());
            DropForeignKey("dbo.ImageFiles", "ProductId", "dbo.Products");
            DropIndex("dbo.ImageFiles", new[] { "ProductId" });
            DropTable("dbo.ImageFiles");
        }
    }
}
