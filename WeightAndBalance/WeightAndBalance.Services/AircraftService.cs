using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WeightAndBalance.Models;
using static WeightAndBalance.Data.IdentityModel;

namespace WeightAndBalance.Services
{
    public class AircraftService
    {
        public AircraftService svc = new AircraftService();

        public IEnumerable<AircraftViewModel> GetAircraft()
        {
            using (var ctx = new CalculatorDbContext())
            {
                var aircraft =
                    ctx
                    .Aircraft;
                return 
                aircraft
                .Select(
                    e =>
                    new AircraftViewModel
                    {
                        AircraftId = e.AircraftId,
                        AircraftMake = e.AircraftMake,
                        AircraftModel = e.AircraftModel,
                        AircraftName = e.AircraftName,
                        BasicEmptyWeight = e.BasicEmptyWeight,
                        BasicEmptyweightMoment = e.BasicEmptyweightMoment,
                        FuelLoad = e.FuelLoad,
                        FuelLoadArm = e.FuelLoadArm,
                        FuelLoadMoment = e.FuelLoadMoment,
                        LandingWeight = e.LandingWeight,
                        LandingWeightMoment = e.LandingWeightMoment,
                        LessFuelForTaxiMoment = e.LessFuelForTaxiMoment,
                        LessFuelForTaxiWeight = e.LessFuelForTaxiWeight,
                        LessFuelToDestination = e.LessFuelToDestination,
                        MaxRampWeight = e.MaxRampWeight,
                        MaxTakeOffWeight = e.MaxTakeOffWeight,
                        Payload = e.Payload,
                        PayloadItems = e.PayloadItems,
                        RampWeight = e.RampWeight,
                        RampWeightMoment = e.RampWeightMoment,
                        TakeOffWeight = e.TakeOffWeight,
                        TakeOffWeightMoment = e.TakeOffWeightMoment,
                        ZeroFuelWeight = e.ZeroFuelWeight,
                        ZeroFuelWeightMax = e.ZeroFuelWeightMax,
                        ZeroFuelWeightMoment = e.ZeroFuelWeightMoment
                    });
            }
        }

        public AircraftViewModel GetAircraftById(int id)
        {
            using (var ctx = new CalculatorDbContext())
            {
                var aircraft =
                    ctx
                    .Aircraft
                    .SingleOrDefault(e => e.AircraftId == id);

                return new AircraftViewModel
                {
                    AircraftId = aircraft.AircraftId,
                    AircraftMake = aircraft.AircraftMake,
                    AircraftModel = aircraft.AircraftModel,
                    AircraftName = aircraft.AircraftName,
                    BasicEmptyWeight = aircraft.BasicEmptyWeight,
                    BasicEmptyweightMoment = aircraft.BasicEmptyweightMoment,
                    FuelLoad = aircraft.FuelLoad,
                    FuelLoadArm = aircraft.FuelLoadArm,
                    FuelLoadMoment = aircraft.FuelLoadMoment,
                    LandingWeight = aircraft.LandingWeight,
                    LandingWeightMoment = aircraft.LandingWeightMoment,
                    LessFuelForTaxiMoment = aircraft.LessFuelForTaxiMoment,
                    LessFuelForTaxiWeight = aircraft.LessFuelForTaxiWeight,
                    LessFuelToDestination = aircraft.LessFuelToDestination,
                    MaxRampWeight = aircraft.MaxRampWeight,
                    MaxTakeOffWeight = aircraft.MaxTakeOffWeight,
                    Payload = aircraft.Payload,
                    PayloadItems = aircraft.PayloadItems,
                    RampWeight = aircraft.RampWeight,
                    RampWeightMoment = aircraft.RampWeightMoment,
                    TakeOffWeight = aircraft.TakeOffWeight,
                    TakeOffWeightMoment = aircraft.TakeOffWeightMoment,
                    ZeroFuelWeight = aircraft.ZeroFuelWeight,
                    ZeroFuelWeightMax = aircraft.ZeroFuelWeightMax,
                    ZeroFuelWeightMoment = aircraft.ZeroFuelWeightMoment
                };
                    
            }
        }
    }
}