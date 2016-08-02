using AircraftBalance.Data;
using AircraftBalance.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static AircraftBalance.Data.IdentityModel;

namespace AircraftBalance.Services
{
    public class AircraftService
    {
        public IEnumerable<Aircraft> GetAircraft()
        {
            using (var ctx = new AircraftBalanceDbContext())
            {
                var aircraft = ctx.Aircraft;
                return
                aircraft
                .Select(
                    e =>
                    new Aircraft
                    {
                        AircraftId = e.AircraftId,
                        AircraftMake = e.AircraftMake,
                        AircraftModel = e.AircraftModel,
                        AircraftName = e.AircraftName,
                        BasicEmptyWeight = e.BasicEmptyWeight,
                        BasicEmptyweightMoment = e.BasicEmptyweightMoment,
                        FuelLoad = e.FuelLoad,
                        FuelLoadArm = e.FuelLoadArm,
                        LandingWeight = e.LandingWeight,
                        LandingWeightMoment = e.LandingWeightMoment,
                        LessFuelForTaxiMoment = e.LessFuelForTaxiMoment,
                        LessFuelForTaxiWeight = e.LessFuelForTaxiWeight,
                        LessFuelToDestination = e.LessFuelToDestination,
                        MaxRampWeight = e.MaxRampWeight,
                        MaxTakeOffWeight = e.MaxTakeOffWeight,
                        RampWeight = e.RampWeight,
                        RampWeightMoment = e.RampWeightMoment,
                        TakeOffWeight = e.TakeOffWeight,
                        TakeOffWeightMoment = e.TakeOffWeightMoment,
                        ZeroFuelWeight = e.ZeroFuelWeight,
                        MaxZeroFuelWeight = e.MaxZeroFuelWeight,
                        ZeroFuelWeightMoment = e.ZeroFuelWeightMoment
                    });
            }
        }

        public Aircraft GetAircraftByID(int id)
        {
            using (var ctx = new AircraftBalanceDbContext())
            {
                var aircraft = ctx.Aircraft.SingleOrDefault(e => e.AircraftId == id);
                return new Aircraft
                {

                };
            }
        }
    }
}
