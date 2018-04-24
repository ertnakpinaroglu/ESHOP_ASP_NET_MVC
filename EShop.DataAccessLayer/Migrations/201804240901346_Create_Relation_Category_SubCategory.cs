namespace EShop.DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Create_Relation_Category_SubCategory : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.SubCategories", "CategoryId", c => c.Int(nullable: false));
            CreateIndex("dbo.SubCategories", "CategoryId");
            AddForeignKey("dbo.SubCategories", "CategoryId", "dbo.Categories", "CategoryId", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.SubCategories", "CategoryId", "dbo.Categories");
            DropIndex("dbo.SubCategories", new[] { "CategoryId" });
            DropColumn("dbo.SubCategories", "CategoryId");
        }
    }
}
