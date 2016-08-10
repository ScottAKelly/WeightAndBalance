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
                    })
                    .ToArray();
            }
        }

        public Aircraft GetAircraftByID(int id)
        {
            using (var ctx = new AircraftBalanceDbContext())
            {
                var aircraft = ctx.Aircraft.SingleOrDefault(e => e.AircraftId == id);
                return new Aircraft
                {
                    AircraftId = aircraft.AircraftId,
                    AircraftMake = aircraft.AircraftMake,
                    AircraftModel = aircraft.AircraftModel,
                    AircraftName = aircraft.AircraftName,
                    BasicEmptyWeight = aircraft.BasicEmptyWeight,
                    BasicEmptyweightMoment = aircraft.BasicEmptyweightMoment,
                    FuelLoad = aircraft.FuelLoad,
                    FuelLoadArm = aircraft.FuelLoadArm,
                    LandingWeight = aircraft.LandingWeight,
                    LandingWeightMoment = aircraft.LandingWeightMoment,
                    LessFuelForTaxiMoment = aircraft.LessFuelForTaxiMoment,
                    LessFuelForTaxiWeight = aircraft.LessFuelForTaxiWeight,
                    LessFuelToDestination = aircraft.LessFuelToDestination,
                    MaxLandingWeight = aircraft.MaxLandingWeight,
                    MaxRampWeight = aircraft.MaxRampWeight,
                    MaxTakeOffWeight = aircraft.MaxTakeOffWeight,
                    MaxZeroFuelWeight = aircraft.MaxZeroFuelWeight,
                    RampWeight = aircraft.RampWeight,
                    RampWeightMoment = aircraft.RampWeightMoment,
                    TakeOffWeight = aircraft.TakeOffWeight,
                    TakeOffWeightMoment = aircraft.TakeOffWeightMoment,
                    ZeroFuelWeight = aircraft.ZeroFuelWeight,
                    ZeroFuelWeightMoment = aircraft.ZeroFuelWeightMoment,
                };
            }
        }
    }
}
