namespace WeightAndBalanceApp.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedMoreArms : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.AircraftEntity", "BasicEmptyWeightArm", c => c.Single(nullable: false));
            AddColumn("dbo.AircraftEntity", "MaxZeroFuelWeight", c => c.Int(nullable: false));
            AddColumn("dbo.AircraftEntity", "ZeroFuelWeightArm", c => c.Single(nullable: false));
            AddColumn("dbo.AircraftEntity", "RampWeightArm", c => c.Single(nullable: false));
            AddColumn("dbo.AircraftEntity", "LessFuelForTaxiArm", c => c.Single(nullable: false));
            AddColumn("dbo.AircraftEntity", "TakeOffWeightArm", c => c.Single(nullable: false));
            AddColumn("dbo.AircraftEntity", "LandingWeightArm", c => c.Single(nullable: false));
            AddColumn("dbo.AircraftEntity", "ZeroFuelWeightForwardCG", c => c.Single(nullable: false));
            AddColumn("dbo.AircraftEntity", "ZeroFuelWeightAftCG", c => c.Single(nullable: false));
            AddColumn("dbo.AircraftEntity", "TakeoffWeightForwardCG", c => c.Single(nullable: false));
            AddColumn("dbo.AircraftEntity", "TakeoffWeightAftCG", c => c.Single(nullable: false));
            AddColumn("dbo.AircraftEntity", "LandingWeightForwardCG", c => c.Single(nullable: false));
            AddColumn("dbo.AircraftEntity", "LandingWeightAftCG", c => c.Single(nullable: false));
            DropColumn("dbo.AircraftEntity", "ZeroFuelWeightMax");
        }
        
        public override void Down()
        {
            AddColumn("dbo.AircraftEntity", "ZeroFuelWeightMax", c => c.Int(nullable: false));
            DropColumn("dbo.AircraftEntity", "LandingWeightAftCG");
            DropColumn("dbo.AircraftEntity", "LandingWeightForwardCG");
            DropColumn("dbo.AircraftEntity", "TakeoffWeightAftCG");
            DropColumn("dbo.AircraftEntity", "TakeoffWeightForwardCG");
            DropColumn("dbo.AircraftEntity", "ZeroFuelWeightAftCG");
            DropColumn("dbo.AircraftEntity", "ZeroFuelWeightForwardCG");
            DropColumn("dbo.AircraftEntity", "LandingWeightArm");
            DropColumn("dbo.AircraftEntity", "TakeOffWeightArm");
            DropColumn("dbo.AircraftEntity", "LessFuelForTaxiArm");
            DropColumn("dbo.AircraftEntity", "RampWeightArm");
            DropColumn("dbo.AircraftEntity", "ZeroFuelWeightArm");
            DropColumn("dbo.AircraftEntity", "MaxZeroFuelWeight");
            DropColumn("dbo.AircraftEntity", "BasicEmptyWeightArm");
        }
    }
}
