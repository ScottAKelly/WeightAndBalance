namespace WeightAndBalanceApp.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updatedforeignKeysAgain : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.PayloadItemsEntity", "Aircraft_AircraftId", "dbo.AircraftEntity");
            DropForeignKey("dbo.PayloadItemsEntity", "PayloadItemId", "dbo.PayloadEntity");
            DropIndex("dbo.PayloadItemsEntity", new[] { "PayloadItemId" });
            DropIndex("dbo.PayloadItemsEntity", new[] { "Aircraft_AircraftId" });
            RenameColumn(table: "dbo.PayloadItemsEntity", name: "Aircraft_AircraftId", newName: "AircraftId");
            DropPrimaryKey("dbo.PayloadItemsEntity");
            AddColumn("dbo.AircraftEntity", "PayloadItemId", c => c.Int(nullable: false));
            AddColumn("dbo.AircraftEntity", "PayloadId", c => c.Int(nullable: false));
            AddColumn("dbo.PayloadEntity", "PayloadItemId", c => c.Int(nullable: false));
            AddColumn("dbo.PayloadItemsEntity", "PayloadId", c => c.Int(nullable: false));
            AlterColumn("dbo.PayloadItemsEntity", "PayloadItemId", c => c.Int(nullable: false, identity: true));
            AlterColumn("dbo.PayloadItemsEntity", "AircraftId", c => c.Int(nullable: false));
            AddPrimaryKey("dbo.PayloadItemsEntity", "PayloadItemId");
            CreateIndex("dbo.PayloadItemsEntity", "PayloadId");
            CreateIndex("dbo.PayloadItemsEntity", "AircraftId");
            AddForeignKey("dbo.PayloadItemsEntity", "AircraftId", "dbo.AircraftEntity", "AircraftId", cascadeDelete: true);
            AddForeignKey("dbo.PayloadItemsEntity", "PayloadId", "dbo.PayloadEntity", "PayloadId", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.PayloadItemsEntity", "PayloadId", "dbo.PayloadEntity");
            DropForeignKey("dbo.PayloadItemsEntity", "AircraftId", "dbo.AircraftEntity");
            DropIndex("dbo.PayloadItemsEntity", new[] { "AircraftId" });
            DropIndex("dbo.PayloadItemsEntity", new[] { "PayloadId" });
            DropPrimaryKey("dbo.PayloadItemsEntity");
            AlterColumn("dbo.PayloadItemsEntity", "AircraftId", c => c.Int());
            AlterColumn("dbo.PayloadItemsEntity", "PayloadItemId", c => c.Int(nullable: false));
            DropColumn("dbo.PayloadItemsEntity", "PayloadId");
            DropColumn("dbo.PayloadEntity", "PayloadItemId");
            DropColumn("dbo.AircraftEntity", "PayloadId");
            DropColumn("dbo.AircraftEntity", "PayloadItemId");
            AddPrimaryKey("dbo.PayloadItemsEntity", "PayloadItemId");
            RenameColumn(table: "dbo.PayloadItemsEntity", name: "AircraftId", newName: "Aircraft_AircraftId");
            CreateIndex("dbo.PayloadItemsEntity", "Aircraft_AircraftId");
            CreateIndex("dbo.PayloadItemsEntity", "PayloadItemId");
            AddForeignKey("dbo.PayloadItemsEntity", "PayloadItemId", "dbo.PayloadEntity", "PayloadId");
            AddForeignKey("dbo.PayloadItemsEntity", "Aircraft_AircraftId", "dbo.AircraftEntity", "AircraftId");
        }
    }
}
