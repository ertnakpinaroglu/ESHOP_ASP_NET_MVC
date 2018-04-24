namespace EShop.DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Relation_Brand_Product : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Products", "Brand_BrandId", c => c.Int());
            AddColumn("dbo.Products", "SubCategory_SubCategoryId", c => c.Int());
            CreateIndex("dbo.Products", "Brand_BrandId");
            CreateIndex("dbo.Products", "SubCategory_SubCategoryId");
            AddForeignKey("dbo.Products", "Brand_BrandId", "dbo.Brands", "BrandId");
            AddForeignKey("dbo.Products", "SubCategory_SubCategoryId", "dbo.SubCategories", "SubCategoryId");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Products", "SubCategory_SubCategoryId", "dbo.SubCategories");
            DropForeignKey("dbo.Products", "Brand_BrandId", "dbo.Brands");
            DropIndex("dbo.Products", new[] { "SubCategory_SubCategoryId" });
            DropIndex("dbo.Products", new[] { "Brand_BrandId" });
            DropColumn("dbo.Products", "SubCategory_SubCategoryId");
            DropColumn("dbo.Products", "Brand_BrandId");
        }
    }
}
