namespace YGN.Store.Management.DataAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class migorderentitychanged : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Orders", "ItemId");
            DropColumn("dbo.Orders", "Amount");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Orders", "Amount", c => c.Int(nullable: false));
            AddColumn("dbo.Orders", "ItemId", c => c.Int(nullable: false));
        }
    }
}
