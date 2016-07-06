namespace WeightAndBalanceApp.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class EditedForeignKeys : DbMigration
    {
        public override void Up()
        {
            DropIndex("dbo.PayloadItemsEntity", new[] { "Payload_PayloadId" });
            DropPrimaryKey("dbo.PayloadItemsEntity");
            AlterColumn("dbo.PayloadItemsEntity", "PayloadItemId", c => c.Int(nullable: false));
            AlterColumn("dbo.PayloadItemsEntity", "PayloadItemId", c => c.Int(nullable: false));
            AddPrimaryKey("dbo.PayloadItemsEntity", "PayloadItemId");
            CreateIndex("dbo.PayloadItemsEntity", "PayloadItemId");
        }
        
        public override void Down()
        {
            DropIndex("dbo.PayloadItemsEntity", new[] { "PayloadItemId" });
            DropPrimaryKey("dbo.PayloadItemsEntity");
            AlterColumn("dbo.PayloadItemsEntity", "PayloadItemId", c => c.Int());
            AlterColumn("dbo.PayloadItemsEntity", "PayloadItemId", c => c.Int(nullable: false, identity: true));
            AddPrimaryKey("dbo.PayloadItemsEntity", "PayloadItemId");
            RenameColumn(table: "dbo.PayloadItemsEntity", name: "PayloadItemId", newName: "Payload_PayloadId");
            AddColumn("dbo.PayloadItemsEntity", "PayloadItemId", c => c.Int(nullable: false, identity: true));
            CreateIndex("dbo.PayloadItemsEntity", "Payload_PayloadId");
        }
    }
}
