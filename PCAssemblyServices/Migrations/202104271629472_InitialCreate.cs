namespace PCAssemblyServices.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Password = c.String(),
                        AccountType = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.ShopBaskets",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        TotalPrice = c.Int(nullable: false),
                        User_Id = c.Int(),
                        PurchaseHistory_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Users", t => t.User_Id)
                .ForeignKey("dbo.PurchaseHistories", t => t.PurchaseHistory_Id)
                .Index(t => t.User_Id)
                .Index(t => t.PurchaseHistory_Id);
            
            CreateTable(
                "dbo.ProductViews",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Price = c.Int(nullable: false),
                        ShopBasket_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.ShopBaskets", t => t.ShopBasket_Id)
                .Index(t => t.ShopBasket_Id);
            
            CreateTable(
                "dbo.PurchaseHistories",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        User_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Users", t => t.User_Id)
                .Index(t => t.User_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.PurchaseHistories", "User_Id", "dbo.Users");
            DropForeignKey("dbo.ShopBaskets", "PurchaseHistory_Id", "dbo.PurchaseHistories");
            DropForeignKey("dbo.ShopBaskets", "User_Id", "dbo.Users");
            DropForeignKey("dbo.ProductViews", "ShopBasket_Id", "dbo.ShopBaskets");
            DropIndex("dbo.PurchaseHistories", new[] { "User_Id" });
            DropIndex("dbo.ProductViews", new[] { "ShopBasket_Id" });
            DropIndex("dbo.ShopBaskets", new[] { "PurchaseHistory_Id" });
            DropIndex("dbo.ShopBaskets", new[] { "User_Id" });
            DropTable("dbo.PurchaseHistories");
            DropTable("dbo.ProductViews");
            DropTable("dbo.ShopBaskets");
            DropTable("dbo.Users");
        }
    }
}
