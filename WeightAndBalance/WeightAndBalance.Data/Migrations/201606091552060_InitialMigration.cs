namespace WeightAndBalance.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialMigration : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.AircraftEntities",
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
                        Payload_PayloadId = c.Int(),
                    })
                .PrimaryKey(t => t.AircraftId)
                .ForeignKey("dbo.Payloads", t => t.Payload_PayloadId)
                .Index(t => t.Payload_PayloadId);
            
            CreateTable(
                "dbo.Payloads",
                c => new
                    {
                        PayloadId = c.Int(nullable: false, identity: true),
                    })
                .PrimaryKey(t => t.PayloadId);
            
            CreateTable(
                "dbo.PayloadItems",
                c => new
                    {
                        PayloadItemId = c.Int(nullable: false, identity: true),
                        PayloadItemWeight = c.Single(nullable: false),
                        PayloadItemMoment = c.Single(nullable: false),
                        PayloadItemArm = c.Single(nullable: false),
                    })
                .PrimaryKey(t => t.PayloadItemId);
            
            CreateTable(
                "dbo.AspNetRoles",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        Name = c.String(nullable: false, maxLength: 256),
                    })
                .PrimaryKey(t => t.Id)
                .Index(t => t.Name, unique: true, name: "RoleNameIndex");
            
            CreateTable(
                "dbo.AspNetUserRoles",
                c => new
                    {
                        UserId = c.String(nullable: false, maxLength: 128),
                        RoleId = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => new { t.UserId, t.RoleId })
                .ForeignKey("dbo.AspNetRoles", t => t.RoleId, cascadeDelete: true)
                .ForeignKey("dbo.AspNetUsers", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId)
                .Index(t => t.RoleId);
            
            CreateTable(
                "dbo.AspNetUsers",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        Email = c.String(maxLength: 256),
                        EmailConfirmed = c.Boolean(nullable: false),
                        PasswordHash = c.String(),
                        SecurityStamp = c.String(),
                        PhoneNumber = c.String(),
                        PhoneNumberConfirmed = c.Boolean(nullable: false),
                        TwoFactorEnabled = c.Boolean(nullable: false),
                        LockoutEndDateUtc = c.DateTime(),
                        LockoutEnabled = c.Boolean(nullable: false),
                        AccessFailedCount = c.Int(nullable: false),
                        UserName = c.String(nullable: false, maxLength: 256),
                    })
                .PrimaryKey(t => t.Id)
                .Index(t => t.UserName, unique: true, name: "UserNameIndex");
            
            CreateTable(
                "dbo.AspNetUserClaims",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        UserId = c.String(nullable: false, maxLength: 128),
                        ClaimType = c.String(),
                        ClaimValue = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.AspNetUsers", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId);
            
            CreateTable(
                "dbo.AspNetUserLogins",
                c => new
                    {
                        LoginProvider = c.String(nullable: false, maxLength: 128),
                        ProviderKey = c.String(nullable: false, maxLength: 128),
                        UserId = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => new { t.LoginProvider, t.ProviderKey, t.UserId })
                .ForeignKey("dbo.AspNetUsers", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.AspNetUserRoles", "UserId", "dbo.AspNetUsers");
            DropForeignKey("dbo.AspNetUserLogins", "UserId", "dbo.AspNetUsers");
            DropForeignKey("dbo.AspNetUserClaims", "UserId", "dbo.AspNetUsers");
            DropForeignKey("dbo.AspNetUserRoles", "RoleId", "dbo.AspNetRoles");
            DropForeignKey("dbo.AircraftEntities", "Payload_PayloadId", "dbo.Payloads");
            DropIndex("dbo.AspNetUserLogins", new[] { "UserId" });
            DropIndex("dbo.AspNetUserClaims", new[] { "UserId" });
            DropIndex("dbo.AspNetUsers", "UserNameIndex");
            DropIndex("dbo.AspNetUserRoles", new[] { "RoleId" });
            DropIndex("dbo.AspNetUserRoles", new[] { "UserId" });
            DropIndex("dbo.AspNetRoles", "RoleNameIndex");
            DropIndex("dbo.AircraftEntities", new[] { "Payload_PayloadId" });
            DropTable("dbo.AspNetUserLogins");
            DropTable("dbo.AspNetUserClaims");
            DropTable("dbo.AspNetUsers");
            DropTable("dbo.AspNetUserRoles");
            DropTable("dbo.AspNetRoles");
            DropTable("dbo.PayloadItems");
            DropTable("dbo.Payloads");
            DropTable("dbo.AircraftEntities");
        }
    }
}
