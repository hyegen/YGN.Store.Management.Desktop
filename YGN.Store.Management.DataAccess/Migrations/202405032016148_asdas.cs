namespace YGN.Store.Management.DataAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class asdas : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Clients",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ClientCode = c.String(maxLength: 100),
                        ClientName = c.String(nullable: false, maxLength: 100),
                        ClientSurname = c.String(maxLength: 100),
                        Address = c.String(maxLength: 200),
                        TelNr1 = c.String(maxLength: 50),
                        TelNr2 = c.String(maxLength: 50),
                        FirmDescription = c.String(maxLength: 150),
                        TaxIdentificationNumber = c.String(maxLength: 50),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Items",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ItemCode = c.String(maxLength: 100),
                        ItemName = c.String(maxLength: 150),
                        UnitPrice = c.Double(),
                        Brand = c.String(maxLength: 100),
                        Amount = c.Int(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.OrderLines",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ItemId = c.Int(nullable: false),
                        Amount = c.Int(nullable: false),
                        DateTime = c.DateTime(nullable: false),
                        LineTotal = c.Decimal(nullable: false, precision: 18, scale: 2),
                        OrderId = c.Int(nullable: false),
                        IOCode = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Items", t => t.ItemId, cascadeDelete: true)
                .ForeignKey("dbo.Orders", t => t.OrderId, cascadeDelete: true)
                .Index(t => t.ItemId)
                .Index(t => t.OrderId);
            
            CreateTable(
                "dbo.Orders",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        DateTime = c.DateTime(nullable: false),
                        TotalPrice = c.Decimal(nullable: false, precision: 18, scale: 2),
                        IOCode = c.Int(nullable: false),
                        ClientId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.StockTransactions",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ItemId = c.Int(nullable: false),
                        OrderId = c.Int(),
                        UserId = c.Int(nullable: false),
                        ProcessDate = c.DateTime(nullable: false),
                        TrCode = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        UserName = c.String(),
                        Password = c.String(),
                        NameSurname = c.String(),
                        Email = c.String(),
                        Gender = c.String(),
                        BirthDate = c.DateTime(storeType: "date"),
                        CreatedDate = c.DateTime(storeType: "date"),
                        TelNr1 = c.String(),
                        TelNr2 = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.OrderLines", "OrderId", "dbo.Orders");
            DropForeignKey("dbo.OrderLines", "ItemId", "dbo.Items");
            DropIndex("dbo.OrderLines", new[] { "OrderId" });
            DropIndex("dbo.OrderLines", new[] { "ItemId" });
            DropTable("dbo.Users");
            DropTable("dbo.StockTransactions");
            DropTable("dbo.Orders");
            DropTable("dbo.OrderLines");
            DropTable("dbo.Items");
            DropTable("dbo.Clients");
        }
    }
}
