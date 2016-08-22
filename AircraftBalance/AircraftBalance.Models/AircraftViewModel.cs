using AircraftBalance.Data;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace AircraftBalance.Models
{
    public class AircraftViewModel
    {
        public int Plane { get; set; }
        public IEnumerable<Aircraft> Aircraft { get; set; }
        public IEnumerable<PayloadItem> PayloadItems { get; set; }
        
        //Basic Properties
        public int AircraftId { get; set; }
        [Display(Name = "Aircraft Name")]
        public string AircraftName { get; set; }
        [Display(Name = "Aircraft Make")]
        public string AircraftMake { get; set; }
        [Display(Name = "Aircraft Model")]
        public string AircraftModel { get; set; }
        public double BasicEmptyWeight { get; set; }
        public double BasicEmptyWeightArm { get; set; }
        public double BasicEmptyweightMoment { get; set; }
        public double ZeroFuelWeight { get; set; }
        public double ZeroFuelWeightArm { get; set; }
        public double ZeroFuelWeightMoment { get; set; }
        [Display(Name = "Fuel Load")]
        public double FuelLoadWeight { get; set; }
        public double FuelLoadMoment { get; set; }
        public double FuelLoadArm { get; set; }
        public double RampWeight { get; set; }
        public double RampWeightArm { get; set; }
        public double RampWeightMoment { get; set; }
        public double LessFuelForTaxiWeight { get; set; }
        [Display(Name = "Less Fuel For Taxi")]
        public double LessFuelForTaxiArm { get; set; }
        public double LessFuelForTaxiMoment { get; set; }
        public double TakeOffWeight { get; set; }
        public double TakeOffWeightArm { get; set; }
        public double TakeOffWeightMoment { get; set; }
        [Display(Name = "Less Fuel to Destination")]
        public double LessFuelToDestination { get; set; }
        public double LandingWeight { get; set; }
        public double LandingWeightArm { get; set; }
        public double LandingWeightMoment { get; set; }

        //Max value properties
        [Display(Name = "Max Landing Weight")]
        public int MaxLandingWeight { get; set; }
        [Display(Name = "Max Ramp Weight")]
        public int MaxRampWeight { get; set; }
        [Display(Name = "Max Takeoff Weight")]
        public int MaxTakeOffWeight { get; set; }
        [Display(Name = "Max Zero Fuel Weight")]
        public int MaxZeroFuelWeight { get; set; }
        [Display(Name = "Forward Limit")]
        public double ZeroFuelWeightForwardCG { get; set; }
        [Display(Name = "Aft Limit")]
        public double ZeroFuelWeightAftCG { get; set; }
        [Display(Name = "Forward Limit")]
        public double TakeoffWeightForwardCG { get; set; }
        [Display(Name = "Aft Limit")]
        public double TakeoffWeightAftCG { get; set; }
        [Display(Name = "Forward Limit")]
        public double LandingWeightForwardCG { get; set; }
        [Display(Name = "Aft Limit")]
        public double LandingWeightAftCG { get; set; }

        //Payload Properties
        public int PayloadId { get; set; }
        public double PayloadWeight { get; set; }
        public double PayloadArm { get; set; }
        public double PayloadMoment { get; set; }

        //Payload Item Properties
        public int PayloadItemId { get; set; }
        public string PayloadItemName { get; set; }
        public double PayloadItemWeight { get; set; }
        public double PayloadItemMoment { get; set; }
        public double PayloadItemArm { get; set; }

    }
}
