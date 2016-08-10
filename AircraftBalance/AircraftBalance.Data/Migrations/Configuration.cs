namespace AircraftBalance.Data.Migrations
{
    using System;
    using System.Collections.Generic;
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

            var Aircraft = new List<Aircraft>
            {

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
                },


                new Aircraft
                {
                    AircraftId = 2,
                    AircraftName = "",
                    AircraftMake = "",
                    AircraftModel = "",
                    BasicEmptyWeight = 0,
                    BasicEmptyweightMoment = 0,
                    LessFuelForTaxiWeight = 0,
                    LessFuelForTaxiMoment = 0,
                    MaxRampWeight = 0,
                    MaxTakeOffWeight = 0,
                    MaxZeroFuelWeight = 0,
                    MaxLandingWeight = 0,
                    FuelLoadArm = 0.0f,
                },


                new Aircraft
                {
                    AircraftId = 3,
                    AircraftName = "",
                    AircraftMake = "",
                    AircraftModel = "",
                    BasicEmptyWeight = 0,
                    BasicEmptyweightMoment = 0,
                    LessFuelForTaxiWeight = 0,
                    LessFuelForTaxiMoment = 0,
                    MaxRampWeight = 0,
                    MaxTakeOffWeight = 0,
                    MaxZeroFuelWeight = 0,
                    MaxLandingWeight = 0,
                    FuelLoadArm = 0.0f,
                },


                new Aircraft
                {
                    AircraftId = 4,
                    AircraftName = "",
                    AircraftMake = "",
                    AircraftModel = "",
                    BasicEmptyWeight = 0,
                    BasicEmptyweightMoment = 0,
                    LessFuelForTaxiWeight = 0,
                    LessFuelForTaxiMoment = 0,
                    MaxRampWeight = 0,
                    MaxTakeOffWeight = 0,
                    MaxZeroFuelWeight = 0,
                    MaxLandingWeight = 0,
                    FuelLoadArm = 0.0f,
                },


                new Aircraft
                {
                    AircraftId = 5,
                    AircraftName = "",
                    AircraftMake = "",
                    AircraftModel = "",
                    BasicEmptyWeight = 0,
                    BasicEmptyweightMoment = 0,
                    LessFuelForTaxiWeight = 0,
                    LessFuelForTaxiMoment = 0,
                    MaxRampWeight = 0,
                    MaxTakeOffWeight = 0,
                    MaxZeroFuelWeight = 0,
                    MaxLandingWeight = 0,
                    FuelLoadArm = 0.0f,
                },


                new Aircraft
                {
                    AircraftId = 6,
                    AircraftName = "",
                    AircraftMake = "",
                    AircraftModel = "",
                    BasicEmptyWeight = 0,
                    BasicEmptyweightMoment = 0,
                    LessFuelForTaxiWeight = 0,
                    LessFuelForTaxiMoment = 0,
                    MaxRampWeight = 0,
                    MaxTakeOffWeight = 0,
                    MaxZeroFuelWeight = 0,
                    MaxLandingWeight = 0,
                    FuelLoadArm = 0.0f,
                },



                new Aircraft
                {
                    AircraftId = 7,
                    AircraftName = "",
                    AircraftMake = "",
                    AircraftModel = "",
                    BasicEmptyWeight = 0,
                    BasicEmptyweightMoment = 0,
                    LessFuelForTaxiWeight = 0,
                    LessFuelForTaxiMoment = 0,
                    MaxRampWeight = 0,
                    MaxTakeOffWeight = 0,
                    MaxZeroFuelWeight = 0,
                    MaxLandingWeight = 0,
                    FuelLoadArm = 0.0f,
                }
            };
            Aircraft.ForEach(s => context.Aircraft.Add(s));
            context.SaveChanges();
        }
    }
}

