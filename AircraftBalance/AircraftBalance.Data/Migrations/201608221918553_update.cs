namespace AircraftBalance.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class update : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.PayloadItem", "PayloadId", "dbo.Payload");
            DropIndex("dbo.PayloadItem", new[] { "PayloadId" });
            DropColumn("dbo.PayloadItem", "PayloadId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.PayloadItem", "PayloadId", c => c.Int(nullable: false));
            CreateIndex("dbo.PayloadItem", "PayloadId");
            AddForeignKey("dbo.PayloadItem", "PayloadId", "dbo.Payload", "PayloadId", cascadeDelete: true);
        }
    }
}
