namespace ConsoleDB.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddAuthor : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Authors",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FirstName = c.String(nullable: false),
                        LastName = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.Books", "Author_Id", c => c.Int());
            CreateIndex("dbo.Books", "Author_Id");
            AddForeignKey("dbo.Books", "Author_Id", "dbo.Authors", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Books", "Author_Id", "dbo.Authors");
            DropIndex("dbo.Books", new[] { "Author_Id" });
            DropColumn("dbo.Books", "Author_Id");
            DropTable("dbo.Authors");
        }
    }
}
