namespace AircraftBalance.Data.Migrations
{
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Data.Entity.Validation;
    using System.Linq;
    using System.Text;
    internal sealed class Configuration : DbMigrationsConfiguration<AircraftBalance.Data.IdentityModel.AircraftBalanceDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        private void SaveChanges(DbContext context)
        {
            try
            {
                context.SaveChanges();
            }
            catch (DbEntityValidationException ex)
            {
                StringBuilder sb = new StringBuilder();

                foreach (var failure in ex.EntityValidationErrors)
                {
                    sb.AppendFormat("{0} failed validation\n", failure.Entry.Entity.GetType());
                    foreach (var error in failure.ValidationErrors)
                    {
                        sb.AppendFormat("- {0} : {1}", error.PropertyName, error.ErrorMessage);
                        sb.AppendLine();
                    }
                }

                throw new DbEntityValidationException(
                    "Entity Validation Failed - errors follow:\n" +
                    sb.ToString(), ex
                ); // Add the original exception as the innerException
            }
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

            var aircraft = new List<Aircraft>
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
                    AircraftName = "Example Name 1",
                    AircraftMake = "Example Make 1",
                    AircraftModel = "Example Model 1",
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
                    AircraftName = "Example Name 2",
                    AircraftMake = "Example Make 2",
                    AircraftModel = "Example Model 2",
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
                    AircraftName = "Example Name 3",
                    AircraftMake = "Example Make 3",
                    AircraftModel = "Example Model 3",
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
                    AircraftName = "Example Name 4",
                    AircraftMake = "Example Make 4",
                    AircraftModel = "Example Model 4",
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
                    AircraftName = "Example Name 5",
                    AircraftMake = "Example Make 5",
                    AircraftModel = "Example Model 5",
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
                    AircraftName = "Example Name 6",
                    AircraftMake = "Example Make 6",
                    AircraftModel = "Example Model 6",
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
            aircraft.ForEach(s => context.Aircraft.Add(s));
            SaveChanges(context);
        }
    }
}

