namespace YGN.Store.Management.DataAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class miggrnlupdate1 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Clients", "ClientCode", c => c.String(maxLength: 100));
            AlterColumn("dbo.Clients", "Address", c => c.String(maxLength: 200));
            AlterColumn("dbo.Clients", "TelNr1", c => c.String(maxLength: 50));
            AlterColumn("dbo.Clients", "TelNr2", c => c.String(maxLength: 50));
            AlterColumn("dbo.Items", "ItemCode", c => c.String(maxLength: 100));
            AlterColumn("dbo.Items", "Brand", c => c.String(maxLength: 100));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Items", "Brand", c => c.String(maxLength: 30));
            AlterColumn("dbo.Items", "ItemCode", c => c.String(maxLength: 40));
            AlterColumn("dbo.Clients", "TelNr2", c => c.String(maxLength: 11));
            AlterColumn("dbo.Clients", "TelNr1", c => c.String(maxLength: 11));
            AlterColumn("dbo.Clients", "Address", c => c.String(maxLength: 30));
            AlterColumn("dbo.Clients", "ClientCode", c => c.String(maxLength: 40));
        }
    }
}
