namespace EShop.DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateColumn_ProfileImage_ProductTable : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Products", "ProfileImage", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Products", "ProfileImage");
        }
    }
}
