namespace AircraftBalance.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updatedConstructors : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Payload", "PayloadWeight", c => c.Double(nullable: false));
            AlterColumn("dbo.Payload", "PayloadArm", c => c.Double(nullable: false));
            AlterColumn("dbo.Payload", "PayloadMoment", c => c.Double(nullable: false));
            AlterColumn("dbo.PayloadItem", "PayloadItemWeight", c => c.Double(nullable: false));
            AlterColumn("dbo.PayloadItem", "PayloadItemArm", c => c.Double(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.PayloadItem", "PayloadItemArm", c => c.Single(nullable: false));
            AlterColumn("dbo.PayloadItem", "PayloadItemWeight", c => c.Single(nullable: false));
            AlterColumn("dbo.Payload", "PayloadMoment", c => c.Single(nullable: false));
            AlterColumn("dbo.Payload", "PayloadArm", c => c.Single(nullable: false));
            AlterColumn("dbo.Payload", "PayloadWeight", c => c.Single(nullable: false));
        }
    }
}
