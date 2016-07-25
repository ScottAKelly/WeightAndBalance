namespace AircraftBalance.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Aircraft",
                c => new
                    {
                        AircraftId = c.Int(nullable: false, identity: true),
                        AircraftName = c.String(nullable: false),
                        AircraftMake = c.String(nullable: false),
                        AircraftModel = c.String(nullable: false),
                        BasicEmptyWeight = c.Int(nullable: false),
                        BasicEmptyWeightArm = c.Single(nullable: false),
                        BasicEmptyweightMoment = c.Single(nullable: false),
                        MaxZeroFuelWeight = c.Int(nullable: false),
                        ZeroFuelWeight = c.Int(nullable: false),
                        ZeroFuelWeightArm = c.Single(nullable: false),
                        ZeroFuelWeightMoment = c.Single(nullable: false),
                        FuelLoad = c.Int(nullable: false),
                        FuelLoadMoment = c.Single(nullable: false),
                        FuelLoadArm = c.Single(nullable: false),
                        MaxRampWeight = c.Int(nullable: false),
                        RampWeight = c.Int(nullable: false),
                        RampWeightArm = c.Single(nullable: false),
                        RampWeightMoment = c.Single(nullable: false),
                        LessFuelForTaxiWeight = c.Int(nullable: false),
                        LessFuelForTaxiArm = c.Single(nullable: false),
                        LessFuelForTaxiMoment = c.Single(nullable: false),
                        MaxTakeOffWeight = c.Int(nullable: false),
                        TakeOffWeight = c.Int(nullable: false),
                        TakeOffWeightArm = c.Single(nullable: false),
                        TakeOffWeightMoment = c.Single(nullable: false),
                        LessFuelToDestination = c.Int(nullable: false),
                        LandingWeight = c.Int(nullable: false),
                        LandingWeightArm = c.Single(nullable: false),
                        LandingWeightMoment = c.Single(nullable: false),
                        ZeroFuelWeightForwardCG = c.Single(nullable: false),
                        ZeroFuelWeightAftCG = c.Single(nullable: false),
                        TakeoffWeightForwardCG = c.Single(nullable: false),
                        TakeoffWeightAftCG = c.Single(nullable: false),
                        LandingWeightForwardCG = c.Single(nullable: false),
                        LandingWeightAftCG = c.Single(nullable: false),
                        PayloadItemId = c.Int(nullable: false),
                        PayloadId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.AircraftId);
            
            CreateTable(
                "dbo.Payload",
                c => new
                    {
                        PayloadId = c.Int(nullable: false),
                        PayloadWeight = c.Single(nullable: false),
                        PayloadArm = c.Single(nullable: false),
                        PayloadMoment = c.Single(nullable: false),
                        PayloadItemId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.PayloadId)
                .ForeignKey("dbo.Aircraft", t => t.PayloadId)
                .Index(t => t.PayloadId);
            
            CreateTable(
                "dbo.PayloadItem",
                c => new
                    {
                        PayloadItemId = c.Int(nullable: false, identity: true),
                        PayloadItemName = c.String(),
                        PayloadItemWeight = c.Single(nullable: false),
                        PayloadItemMoment = c.Single(nullable: false),
                        PayloadItemArm = c.Single(nullable: false),
                        PayloadId = c.Int(nullable: false),
                        AircraftId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.PayloadItemId)
                .ForeignKey("dbo.Aircraft", t => t.AircraftId, cascadeDelete: true)
                .ForeignKey("dbo.Payload", t => t.PayloadId, cascadeDelete: true)
                .Index(t => t.PayloadId)
                .Index(t => t.AircraftId);
            
            CreateTable(
                "dbo.IdentityRole",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.IdentityUserRole",
                c => new
                    {
                        RoleId = c.String(nullable: false, maxLength: 128),
                        UserId = c.String(),
                        IdentityRole_Id = c.String(maxLength: 128),
                        WeightAndBalanceAppUser_Id = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.RoleId)
                .ForeignKey("dbo.IdentityRole", t => t.IdentityRole_Id)
                .ForeignKey("dbo.WeightAndBalanceAppUser", t => t.WeightAndBalanceAppUser_Id)
                .Index(t => t.IdentityRole_Id)
                .Index(t => t.WeightAndBalanceAppUser_Id);
            
            CreateTable(
                "dbo.WeightAndBalanceAppUser",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        Email = c.String(),
                        EmailConfirmed = c.Boolean(nullable: false),
                        PasswordHash = c.String(),
                        SecurityStamp = c.String(),
                        PhoneNumber = c.String(),
                        PhoneNumberConfirmed = c.Boolean(nullable: false),
                        TwoFactorEnabled = c.Boolean(nullable: false),
                        LockoutEndDateUtc = c.DateTime(),
                        LockoutEnabled = c.Boolean(nullable: false),
                        AccessFailedCount = c.Int(nullable: false),
                        UserName = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.IdentityUserClaim",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        UserId = c.String(),
                        ClaimType = c.String(),
                        ClaimValue = c.String(),
                        WeightAndBalanceAppUser_Id = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.WeightAndBalanceAppUser", t => t.WeightAndBalanceAppUser_Id)
                .Index(t => t.WeightAndBalanceAppUser_Id);
            
            CreateTable(
                "dbo.IdentityUserLogin",
                c => new
                    {
                        UserId = c.String(nullable: false, maxLength: 128),
                        LoginProvider = c.String(),
                        ProviderKey = c.String(),
                        WeightAndBalanceAppUser_Id = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.UserId)
                .ForeignKey("dbo.WeightAndBalanceAppUser", t => t.WeightAndBalanceAppUser_Id)
                .Index(t => t.WeightAndBalanceAppUser_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.IdentityUserRole", "WeightAndBalanceAppUser_Id", "dbo.WeightAndBalanceAppUser");
            DropForeignKey("dbo.IdentityUserLogin", "WeightAndBalanceAppUser_Id", "dbo.WeightAndBalanceAppUser");
            DropForeignKey("dbo.IdentityUserClaim", "WeightAndBalanceAppUser_Id", "dbo.WeightAndBalanceAppUser");
            DropForeignKey("dbo.IdentityUserRole", "IdentityRole_Id", "dbo.IdentityRole");
            DropForeignKey("dbo.PayloadItem", "PayloadId", "dbo.Payload");
            DropForeignKey("dbo.PayloadItem", "AircraftId", "dbo.Aircraft");
            DropForeignKey("dbo.Payload", "PayloadId", "dbo.Aircraft");
            DropIndex("dbo.IdentityUserLogin", new[] { "WeightAndBalanceAppUser_Id" });
            DropIndex("dbo.IdentityUserClaim", new[] { "WeightAndBalanceAppUser_Id" });
            DropIndex("dbo.IdentityUserRole", new[] { "WeightAndBalanceAppUser_Id" });
            DropIndex("dbo.IdentityUserRole", new[] { "IdentityRole_Id" });
            DropIndex("dbo.PayloadItem", new[] { "AircraftId" });
            DropIndex("dbo.PayloadItem", new[] { "PayloadId" });
            DropIndex("dbo.Payload", new[] { "PayloadId" });
            DropTable("dbo.IdentityUserLogin");
            DropTable("dbo.IdentityUserClaim");
            DropTable("dbo.WeightAndBalanceAppUser");
            DropTable("dbo.IdentityUserRole");
            DropTable("dbo.IdentityRole");
            DropTable("dbo.PayloadItem");
            DropTable("dbo.Payload");
            DropTable("dbo.Aircraft");
        }
    }
}
