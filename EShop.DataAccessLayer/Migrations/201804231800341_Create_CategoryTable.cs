namespace EShop.DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Create_CategoryTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Categories",
                c => new
                    {
                        CategoryId = c.Int(nullable: false, identity: true),
                        CategoryName = c.String(),
                        CategoryDescription = c.String(),
                        CreatedDate = c.DateTime(),
                        ModifiedDate = c.DateTime(),
                        RemovedDate = c.DateTime(),
                    })
                .PrimaryKey(t => t.CategoryId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Categories");
        }
    }
}
