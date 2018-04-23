namespace EShop.DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Create_CommentTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Comments",
                c => new
                    {
                        CommentId = c.Int(nullable: false, identity: true),
                        Text = c.String(),
                        IsActive = c.String(),
                        CreatedDate = c.DateTime(),
                        ModifiedDate = c.DateTime(),
                        RemovedDate = c.DateTime(),
                    })
                .PrimaryKey(t => t.CommentId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Comments");
        }
    }
}
