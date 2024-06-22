namespace YGN.Store.Management.DataAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class migrelationmailling : DbMigration
    {
        public override void Up()
        {
            DropPrimaryKey("dbo.Reports");
            AddColumn("dbo.SendMailContents", "ReportId", c => c.Int(nullable: false));
            AlterColumn("dbo.Reports", "Id", c => c.Int(nullable: false));
            AddPrimaryKey("dbo.Reports", "Id");
            CreateIndex("dbo.Reports", "Id");
            AddForeignKey("dbo.Reports", "Id", "dbo.SendMailContents", "Id");
            DropColumn("dbo.Reports", "ReportBinaryData");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Reports", "ReportBinaryData", c => c.String());
            DropForeignKey("dbo.Reports", "Id", "dbo.SendMailContents");
            DropIndex("dbo.Reports", new[] { "Id" });
            DropPrimaryKey("dbo.Reports");
            AlterColumn("dbo.Reports", "Id", c => c.Int(nullable: false, identity: true));
            DropColumn("dbo.SendMailContents", "ReportId");
            AddPrimaryKey("dbo.Reports", "Id");
        }
    }
}
