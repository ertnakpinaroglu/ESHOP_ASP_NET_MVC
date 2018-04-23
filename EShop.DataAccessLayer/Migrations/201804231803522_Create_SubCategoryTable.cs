namespace EShop.DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Create_SubCategoryTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.SubCategories",
                c => new
                    {
                        SubCategoryId = c.Int(nullable: false, identity: true),
                        SubCategoryName = c.String(),
                        SubCategoryDescription = c.String(),
                        CreatedDate = c.DateTime(),
                        ModifiedDate = c.DateTime(),
                        RemovedDate = c.DateTime(),
                    })
                .PrimaryKey(t => t.SubCategoryId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.SubCategories");
        }
    }
}
