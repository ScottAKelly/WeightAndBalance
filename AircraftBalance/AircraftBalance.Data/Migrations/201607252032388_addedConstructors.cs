namespace AircraftBalance.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addedConstructors : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Aircraft", "BasicEmptyWeightArm");
            DropColumn("dbo.PayloadItem", "PayloadItemMoment");
        }
        
        public override void Down()
        {
            AddColumn("dbo.PayloadItem", "PayloadItemMoment", c => c.Single(nullable: false));
            AddColumn("dbo.Aircraft", "BasicEmptyWeightArm", c => c.Single(nullable: false));
        }
    }
}
