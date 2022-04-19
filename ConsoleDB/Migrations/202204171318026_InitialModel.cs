namespace ConsoleDB.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialModel : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Books",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Title = c.String(nullable: false),
                        Description = c.String(nullable: false),
                        Publisher = c.String(),
                        RentPrice = c.Double(nullable: false),
                        SalePrice = c.Double(nullable: false),
                        RentBook_Id = c.Int(),
                        SaleBook_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.RentBooks", t => t.RentBook_Id)
                .ForeignKey("dbo.SaleBooks", t => t.SaleBook_Id)
                .Index(t => t.RentBook_Id)
                .Index(t => t.SaleBook_Id);
            
            CreateTable(
                "dbo.RentBooks",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        RentDate = c.DateTime(nullable: false),
                        ReturningDeadline = c.DateTime(nullable: false),
                        ReturningDate = c.DateTime(nullable: false),
                        Dalay = c.Int(nullable: false),
                        Price = c.Double(nullable: false),
                        User_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Users", t => t.User_Id)
                .Index(t => t.User_Id);
            
            CreateTable(
                "dbo.SaleBooks",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        SaleDate = c.DateTime(nullable: false),
                        Price = c.Double(nullable: false),
                        User_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Users", t => t.User_Id)
                .Index(t => t.User_Id);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FirstName = c.String(nullable: false),
                        LastName = c.String(nullable: false),
                        Email = c.String(nullable: false),
                        Address = c.String(nullable: false),
                        Password = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.SaleBooks", "User_Id", "dbo.Users");
            DropForeignKey("dbo.RentBooks", "User_Id", "dbo.Users");
            DropForeignKey("dbo.Books", "SaleBook_Id", "dbo.SaleBooks");
            DropForeignKey("dbo.Books", "RentBook_Id", "dbo.RentBooks");
            DropIndex("dbo.SaleBooks", new[] { "User_Id" });
            DropIndex("dbo.RentBooks", new[] { "User_Id" });
            DropIndex("dbo.Books", new[] { "SaleBook_Id" });
            DropIndex("dbo.Books", new[] { "RentBook_Id" });
            DropTable("dbo.Users");
            DropTable("dbo.SaleBooks");
            DropTable("dbo.RentBooks");
            DropTable("dbo.Books");
        }
    }
}
