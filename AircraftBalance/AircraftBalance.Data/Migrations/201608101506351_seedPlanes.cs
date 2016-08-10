namespace AircraftBalance.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class seedPlanes : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Aircraft", "MaxLandingWeight", c => c.Double(nullable: false));
            AlterColumn("dbo.Aircraft", "BasicEmptyWeight", c => c.Double(nullable: false));
            AlterColumn("dbo.Aircraft", "BasicEmptyweightMoment", c => c.Double(nullable: false));
            AlterColumn("dbo.Aircraft", "MaxZeroFuelWeight", c => c.Double(nullable: false));
            AlterColumn("dbo.Aircraft", "ZeroFuelWeight", c => c.Double(nullable: false));
            AlterColumn("dbo.Aircraft", "ZeroFuelWeightMoment", c => c.Double(nullable: false));
            AlterColumn("dbo.Aircraft", "FuelLoad", c => c.Double(nullable: false));
            AlterColumn("dbo.Aircraft", "FuelLoadMoment", c => c.Double(nullable: false));
            AlterColumn("dbo.Aircraft", "FuelLoadArm", c => c.Double(nullable: false));
            AlterColumn("dbo.Aircraft", "MaxRampWeight", c => c.Double(nullable: false));
            AlterColumn("dbo.Aircraft", "RampWeight", c => c.Double(nullable: false));
            AlterColumn("dbo.Aircraft", "RampWeightMoment", c => c.Double(nullable: false));
            AlterColumn("dbo.Aircraft", "LessFuelForTaxiWeight", c => c.Double(nullable: false));
            AlterColumn("dbo.Aircraft", "LessFuelForTaxiMoment", c => c.Double(nullable: false));
            AlterColumn("dbo.Aircraft", "MaxTakeOffWeight", c => c.Double(nullable: false));
            AlterColumn("dbo.Aircraft", "TakeOffWeight", c => c.Double(nullable: false));
            AlterColumn("dbo.Aircraft", "TakeOffWeightMoment", c => c.Double(nullable: false));
            AlterColumn("dbo.Aircraft", "LessFuelToDestination", c => c.Double(nullable: false));
            AlterColumn("dbo.Aircraft", "LandingWeight", c => c.Double(nullable: false));
            AlterColumn("dbo.Aircraft", "LandingWeightMoment", c => c.Double(nullable: false));
            AlterColumn("dbo.Aircraft", "ZeroFuelWeightForwardCG", c => c.Double(nullable: false));
            AlterColumn("dbo.Aircraft", "ZeroFuelWeightAftCG", c => c.Double(nullable: false));
            AlterColumn("dbo.Aircraft", "TakeoffWeightForwardCG", c => c.Double(nullable: false));
            AlterColumn("dbo.Aircraft", "TakeoffWeightAftCG", c => c.Double(nullable: false));
            AlterColumn("dbo.Aircraft", "LandingWeightForwardCG", c => c.Double(nullable: false));
            AlterColumn("dbo.Aircraft", "LandingWeightAftCG", c => c.Double(nullable: false));
            DropColumn("dbo.Aircraft", "ZeroFuelWeightArm");
            DropColumn("dbo.Aircraft", "RampWeightArm");
            DropColumn("dbo.Aircraft", "LessFuelForTaxiArm");
            DropColumn("dbo.Aircraft", "TakeOffWeightArm");
            DropColumn("dbo.Aircraft", "LandingWeightArm");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Aircraft", "LandingWeightArm", c => c.Single(nullable: false));
            AddColumn("dbo.Aircraft", "TakeOffWeightArm", c => c.Single(nullable: false));
            AddColumn("dbo.Aircraft", "LessFuelForTaxiArm", c => c.Single(nullable: false));
            AddColumn("dbo.Aircraft", "RampWeightArm", c => c.Single(nullable: false));
            AddColumn("dbo.Aircraft", "ZeroFuelWeightArm", c => c.Single(nullable: false));
            AlterColumn("dbo.Aircraft", "LandingWeightAftCG", c => c.Single(nullable: false));
            AlterColumn("dbo.Aircraft", "LandingWeightForwardCG", c => c.Single(nullable: false));
            AlterColumn("dbo.Aircraft", "TakeoffWeightAftCG", c => c.Single(nullable: false));
            AlterColumn("dbo.Aircraft", "TakeoffWeightForwardCG", c => c.Single(nullable: false));
            AlterColumn("dbo.Aircraft", "ZeroFuelWeightAftCG", c => c.Single(nullable: false));
            AlterColumn("dbo.Aircraft", "ZeroFuelWeightForwardCG", c => c.Single(nullable: false));
            AlterColumn("dbo.Aircraft", "LandingWeightMoment", c => c.Single(nullable: false));
            AlterColumn("dbo.Aircraft", "LandingWeight", c => c.Int(nullable: false));
            AlterColumn("dbo.Aircraft", "LessFuelToDestination", c => c.Int(nullable: false));
            AlterColumn("dbo.Aircraft", "TakeOffWeightMoment", c => c.Single(nullable: false));
            AlterColumn("dbo.Aircraft", "TakeOffWeight", c => c.Int(nullable: false));
            AlterColumn("dbo.Aircraft", "MaxTakeOffWeight", c => c.Int(nullable: false));
            AlterColumn("dbo.Aircraft", "LessFuelForTaxiMoment", c => c.Single(nullable: false));
            AlterColumn("dbo.Aircraft", "LessFuelForTaxiWeight", c => c.Int(nullable: false));
            AlterColumn("dbo.Aircraft", "RampWeightMoment", c => c.Single(nullable: false));
            AlterColumn("dbo.Aircraft", "RampWeight", c => c.Int(nullable: false));
            AlterColumn("dbo.Aircraft", "MaxRampWeight", c => c.Int(nullable: false));
            AlterColumn("dbo.Aircraft", "FuelLoadArm", c => c.Single(nullable: false));
            AlterColumn("dbo.Aircraft", "FuelLoadMoment", c => c.Single(nullable: false));
            AlterColumn("dbo.Aircraft", "FuelLoad", c => c.Int(nullable: false));
            AlterColumn("dbo.Aircraft", "ZeroFuelWeightMoment", c => c.Single(nullable: false));
            AlterColumn("dbo.Aircraft", "ZeroFuelWeight", c => c.Int(nullable: false));
            AlterColumn("dbo.Aircraft", "MaxZeroFuelWeight", c => c.Int(nullable: false));
            AlterColumn("dbo.Aircraft", "BasicEmptyweightMoment", c => c.Single(nullable: false));
            AlterColumn("dbo.Aircraft", "BasicEmptyWeight", c => c.Int(nullable: false));
            DropColumn("dbo.Aircraft", "MaxLandingWeight");
        }
    }
}
