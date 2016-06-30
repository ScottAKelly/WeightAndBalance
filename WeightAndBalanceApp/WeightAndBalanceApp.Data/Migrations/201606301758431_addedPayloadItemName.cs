namespace WeightAndBalanceApp.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addedPayloadItemName : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.PayloadItemsEntity",
                c => new
                    {
                        PayloadItemId = c.Int(nullable: false, identity: true),
                        PayloadItemName = c.String(),
                        PayloadItemWeight = c.Single(nullable: false),
                        PayloadItemMoment = c.Single(nullable: false),
                        PayloadItemArm = c.Single(nullable: false),
                        Aircraft_AircraftId = c.Int(),
                        Payload_PayloadId = c.Int(),
                    })
                .PrimaryKey(t => t.PayloadItemId)
                .ForeignKey("dbo.AircraftEntity", t => t.Aircraft_AircraftId)
                .ForeignKey("dbo.PayloadEntity", t => t.Payload_PayloadId)
                .Index(t => t.Aircraft_AircraftId)
                .Index(t => t.Payload_PayloadId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.PayloadItemsEntity", "Payload_PayloadId", "dbo.PayloadEntity");
            DropForeignKey("dbo.PayloadItemsEntity", "Aircraft_AircraftId", "dbo.AircraftEntity");
            DropIndex("dbo.PayloadItemsEntity", new[] { "Payload_PayloadId" });
            DropIndex("dbo.PayloadItemsEntity", new[] { "Aircraft_AircraftId" });
            DropTable("dbo.PayloadItemsEntity");
        }
    }
}
