using AircraftBalance.Data;
using AircraftBalance.Models;
using System.Collections.Generic;
using System.Linq;

namespace AircraftBalance.BusinessLogic
{
    public class Calculation
    {
        private Payload _payload;

        public Payload CreateFromItems(IEnumerable<PayloadItem> items)
        {
            var weight = items.Sum(i => i.PayloadItemWeight);
            var moment = items.Sum(i => i.PayloadItemMoment);
            var arm = (moment / weight);

            return new Payload(arm, weight, moment);
        }

        public double CalculateZeroFuelCG(AircraftViewModel viewModel, Payload payload)
        {
            var zeroFuelCg = viewModel.ZeroFuelWeightArm;

            viewModel.ZeroFuelWeight = (viewModel.BasicEmptyWeight + payload.PayloadWeight);
            viewModel.ZeroFuelWeightMoment = (viewModel.BasicEmptyweightMoment + payload.PayloadMoment);

            zeroFuelCg = (viewModel.ZeroFuelWeight + viewModel.ZeroFuelWeightMoment);

            return zeroFuelCg;
        }

        public double CalculateTakeoffCG(AircraftViewModel viewModel, Payload payload)
        {
            var takeoffCg = viewModel.TakeOffWeightArm;

            viewModel.ZeroFuelWeight = (viewModel.BasicEmptyWeight + payload.PayloadWeight);
            viewModel.RampWeight = (viewModel.ZeroFuelWeight + viewModel.FuelLoadWeight);
            viewModel.TakeOffWeight = (viewModel.RampWeight - viewModel.LessFuelForTaxiWeight);
            
            viewModel.ZeroFuelWeightMoment = (viewModel.BasicEmptyweightMoment + payload.PayloadMoment);
            viewModel.FuelLoadMoment = (viewModel.FuelLoadWeight * viewModel.FuelLoadArm);
            viewModel.RampWeightMoment = (viewModel.ZeroFuelWeightMoment + viewModel.FuelLoadMoment);
            viewModel.TakeOffWeightMoment = (viewModel.RampWeightMoment - viewModel.LessFuelForTaxiMoment);

            takeoffCg = viewModel.TakeOffWeight * viewModel.TakeOffWeightMoment;

            return takeoffCg;
        }

        public double CalculateLandingCG(AircraftViewModel viewModel, Payload payload)
        {
            var landingCg = viewModel.LandingWeightArm;

            viewModel.ZeroFuelWeight = (viewModel.BasicEmptyWeight + payload.PayloadWeight);
            viewModel.RampWeight = (viewModel.ZeroFuelWeight + viewModel.FuelLoadWeight);
            viewModel.TakeOffWeight = (viewModel.RampWeight - viewModel.LessFuelForTaxiWeight);
            viewModel.LandingWeight = (viewModel.TakeOffWeight - viewModel.LessFuelToDestination);
          
            viewModel.ZeroFuelWeightMoment = (viewModel.BasicEmptyweightMoment + payload.PayloadMoment);
            viewModel.FuelLoadMoment = (viewModel.FuelLoadWeight * viewModel.FuelLoadArm);
            viewModel.RampWeightMoment = (viewModel.ZeroFuelWeightMoment + viewModel.FuelLoadMoment);
            viewModel.TakeOffWeightMoment = (viewModel.RampWeightMoment - viewModel.LessFuelForTaxiMoment);
            viewModel.LandingWeightMoment = (viewModel.LandingWeight * viewModel.LandingWeightArm);

            landingCg = viewModel.LandingWeight * viewModel.LandingWeightMoment;

            return landingCg;

        }






        //class PayloadItem
        //{
        //    public PayloadItem(
        //        PayloadItemType itemType,
        //        string itemName,
        //        double arm,
        //        double weight)
        //    {
        //        ItemType = itemType;
        //        ItemName = itemName;
        //        Arm = arm;
        //        Weight = weight;
        //    }

        //    public PayloadItemType ItemType { get; }
        //    public string ItemName { get; }
        //    public double Arm { get; }
        //    public double Weight { get; }

        //    public double Moment => (Arm * Weight) / 100;
        //}

        //class Payload
        //{
        //    public static Payload CreateFromItems(IEnumerable<PayloadItem> items)
        //    {
        //        var weight = items.Sum(i => i.Weight);
        //        var moment = items.Sum(i => i.Moment);
        //        var arm = moment / weight;

        //        return new Payload(arm, weight, moment);
        //    }

        //    private Payload(double arm, double weight, double moment)
        //    {
        //        Arm = arm;
        //        Weight = weight;
        //        Moment = moment;
        //    }

        //    public double Arm { get; }
        //    public double Weight { get; }
        //    public double Moment { get; }
        //}

        //void Main()
        //{
        //    var items =
        //        new[]
        //        {
        //    new PayloadItem(PayloadItemType.Seat, "Seat 1", 143.9, 215),
        //    new PayloadItem(PayloadItemType.Seat, "Seat 2", 143.9, 200),
        //    new PayloadItem(PayloadItemType.Seat, "Seat 3", 229.5, 0),
        //    new PayloadItem(PayloadItemType.Seat, "Seat 4", 229.5, 0),
        //    new PayloadItem(PayloadItemType.Seat, "Seat 5", 283.7, 0),
        //    new PayloadItem(PayloadItemType.Seat, "Seat 6", 283.7, 0),
        //    new PayloadItem(PayloadItemType.Seat, "Seat 7", 327.2, 0),
        //    new PayloadItem(PayloadItemType.Seat, "Seat 8", 327.2, 0),
        //    new PayloadItem(PayloadItemType.Seat, "Seat 9", 186.2, 0),
        //    new PayloadItem(PayloadItemType.Seat, "Seat 10", 205.91, 0),
        //    new PayloadItem(PayloadItemType.Seat, "Seat 11", 357.5, 0),
        //    new PayloadItem(PayloadItemType.Baggage, "Nav Charts", 158.10, 30),
        //    new PayloadItem(PayloadItemType.Baggage, "L/H Fwd Ref", 173.15, 25),
        //    new PayloadItem(PayloadItemType.Baggage, "Tailcone", 431.0, 0),
        //    new PayloadItem(PayloadItemType.Baggage, "RH Fwd Closet", 169.89, 10),
        //    new PayloadItem(PayloadItemType.Baggage, "AFT Closet", 374.0, 0)
        //        }
        //    .Dump("Items");

        //    items.Where(i => i.ItemType == PayloadItemType.Seat).Dump("Seats");
        //    items.Where(i => i.ItemType == PayloadItemType.Baggage).Dump("Baggage");

        //    var payload =
        //        Payload
        //            .CreateFromItems(items)
        //            .Dump("Payload");
        //}

    }
}
