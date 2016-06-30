namespace WeightAndBalanceApp.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.AircraftEntity",
                c => new
                    {
                        AircraftId = c.Int(nullable: false, identity: true),
                        AircraftName = c.String(nullable: false),
                        AircraftMake = c.String(nullable: false),
                        AircraftModel = c.String(nullable: false),
                        BasicEmptyWeight = c.Int(nullable: false),
                        BasicEmptyweightMoment = c.Single(nullable: false),
                        ZeroFuelWeightMax = c.Int(nullable: false),
                        ZeroFuelWeight = c.Int(nullable: false),
                        ZeroFuelWeightMoment = c.Single(nullable: false),
                        FuelLoad = c.Int(nullable: false),
                        FuelLoadMoment = c.Single(nullable: false),
                        FuelLoadArm = c.Single(nullable: false),
                        MaxRampWeight = c.Int(nullable: false),
                        RampWeight = c.Int(nullable: false),
                        RampWeightMoment = c.Single(nullable: false),
                        LessFuelForTaxiWeight = c.Int(nullable: false),
                        LessFuelForTaxiMoment = c.Single(nullable: false),
                        MaxTakeOffWeight = c.Int(nullable: false),
                        TakeOffWeight = c.Int(nullable: false),
                        TakeOffWeightMoment = c.Single(nullable: false),
                        LessFuelToDestination = c.Int(nullable: false),
                        LandingWeight = c.Int(nullable: false),
                        LandingWeightMoment = c.Single(nullable: false),
                    })
                .PrimaryKey(t => t.AircraftId);
            
            CreateTable(
                "dbo.PayloadEntity",
                c => new
                    {
                        PayloadId = c.Int(nullable: false),
                        PayloadWeight = c.Single(nullable: false),
                        PayloadArm = c.Single(nullable: false),
                        PayloadMoment = c.Single(nullable: false),
                    })
                .PrimaryKey(t => t.PayloadId)
                .ForeignKey("dbo.AircraftEntity", t => t.PayloadId)
                .Index(t => t.PayloadId);
            
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
            DropForeignKey("dbo.PayloadEntity", "PayloadId", "dbo.AircraftEntity");
            DropIndex("dbo.IdentityUserLogin", new[] { "WeightAndBalanceAppUser_Id" });
            DropIndex("dbo.IdentityUserClaim", new[] { "WeightAndBalanceAppUser_Id" });
            DropIndex("dbo.IdentityUserRole", new[] { "WeightAndBalanceAppUser_Id" });
            DropIndex("dbo.IdentityUserRole", new[] { "IdentityRole_Id" });
            DropIndex("dbo.PayloadEntity", new[] { "PayloadId" });
            DropTable("dbo.IdentityUserLogin");
            DropTable("dbo.IdentityUserClaim");
            DropTable("dbo.WeightAndBalanceAppUser");
            DropTable("dbo.IdentityUserRole");
            DropTable("dbo.IdentityRole");
            DropTable("dbo.PayloadEntity");
            DropTable("dbo.AircraftEntity");
        }
    }
}
