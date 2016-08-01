namespace AircraftBalance.Data.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<AircraftBalance.Data.IdentityModel.AircraftBalanceDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(AircraftBalance.Data.IdentityModel.AircraftBalanceDbContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );



            context.Aircraft.AddOrUpdate(
                p => p.AircraftName,
                new Aircraft
                {
                    AircraftId = 1,
                    AircraftName = "N580EE",
                    AircraftMake = "Cessna",
                    AircraftModel = "XL",
                    BasicEmptyWeight = 12454,
                    BasicEmptyweightMoment = 4221285f,
                    LessFuelForTaxiWeight = 200,
                    LessFuelForTaxiMoment = 656,
                    MaxRampWeight = 20200,
                    MaxTakeOffWeight = 20000,
                    MaxZeroFuelWeight = 15000,
                    MaxLandingWeight = 18700,
                    FuelLoadArm = 326.9228f,
                });

        }
    }
}
