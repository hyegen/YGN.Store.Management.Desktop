namespace YGN.Store.Management.DataAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class migaddedtrcodetoorderandorderline : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.OrderLines", "TransactionCode", c => c.Int(nullable: false));
            AddColumn("dbo.Orders", "TransactionCode", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Orders", "TransactionCode");
            DropColumn("dbo.OrderLines", "TransactionCode");
        }
    }
}
