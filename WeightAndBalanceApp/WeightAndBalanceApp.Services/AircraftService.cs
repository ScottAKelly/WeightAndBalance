using System.Collections.Generic;
using System.Linq;
using WeightAndBalanceApp.Data;
using WeightAndBalanceApp.Models;
using static WeightAndBalanceApp.Data.IdentityModel;

namespace WeightAndBalanceApp.Services
{
    public class AircraftService
    {
        public AircraftService svc = new AircraftService();

        public IEnumerable<AircraftViewModel> GetAircraft()
        {
            using (var ctx = new WeightAndBalanceDbContext())
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

        public AircraftViewModel GetAircraftById(int aircraftId)
        {
            using (var ctx = new WeightAndBalanceDbContext())
            {
                var aircraft =
                    ctx
                    .Aircraft
                    .SingleOrDefault(e => e.AircraftId == aircraftId);

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

        public bool CreateAircraft(AircraftViewModel vm)
        {
            using (var ctx = new WeightAndBalanceDbContext())
            {
                var entity =
                    new AircraftEntity
                    {
                        AircraftId = vm.AircraftId,
                        AircraftName = vm.AircraftName,
                        AircraftMake = vm.AircraftMake,
                        AircraftModel = vm.AircraftModel,
                        BasicEmptyWeight = vm.BasicEmptyWeight,
                        BasicEmptyweightMoment = vm.BasicEmptyweightMoment,
                        FuelLoad = vm.FuelLoad,
                        FuelLoadArm = vm.FuelLoadArm,
                        FuelLoadMoment = vm.FuelLoadMoment,
                        LandingWeight = vm.LandingWeight,
                        LandingWeightMoment = vm.LandingWeightMoment,
                        LessFuelForTaxiMoment = vm.LessFuelForTaxiMoment,
                        LessFuelForTaxiWeight = vm.LessFuelForTaxiWeight,
                        LessFuelToDestination = vm.LessFuelToDestination,
                        MaxRampWeight = vm.MaxRampWeight,
                        MaxTakeOffWeight = vm.MaxTakeOffWeight,
                        RampWeight = vm.RampWeight,
                        RampWeightMoment = vm.RampWeightMoment,
                        TakeOffWeight = vm.TakeOffWeight,
                        TakeOffWeightMoment = vm.TakeOffWeightMoment,
                        ZeroFuelWeight = vm.ZeroFuelWeight,
                        ZeroFuelWeightMax = vm.ZeroFuelWeightMax,
                        ZeroFuelWeightMoment = vm.ZeroFuelWeightMoment
                    };
                ctx.Aircraft.Add(entity);
                return ctx.SaveChanges() == 1;
            }
        }
    }
}