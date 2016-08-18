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
        public int BasicEmptyWeight { get; set; }
        public float BasicEmptyWeightArm { get; set; }
        public float BasicEmptyweightMoment { get; set; }
        public int ZeroFuelWeight { get; set; }
        public float ZeroFuelWeightArm { get; set; }
        public float ZeroFuelWeightMoment { get; set; }
        [Display(Name = "Fuel Load")]
        public int FuelLoadWeight { get; set; }
        public float FuelLoadMoment { get; set; }
        public float FuelLoadArm { get; set; }
        public int RampWeight { get; set; }
        public float RampWeightArm { get; set; }
        public float RampWeightMoment { get; set; }
        public int LessFuelForTaxiWeight { get; set; }
        [Display(Name = "Less Fuel For Taxi")]
        public float LessFuelForTaxiArm { get; set; }
        public float LessFuelForTaxiMoment { get; set; }
        public int TakeOffWeight { get; set; }
        public float TakeOffWeightArm { get; set; }
        public float TakeOffWeightMoment { get; set; }
        [Display(Name = "Less Fuel to Destination")]
        public int LessFuelToDestination { get; set; }
        public int LandingWeight { get; set; }
        public float LandingWeightArm { get; set; }
        public float LandingWeightMoment { get; set; }

        ////Max value properties
        //[Display(Name = "Max Landing Weight")]
        //public int MaxLandingWeight { get; set; }
        //[Display(Name = "Max Ramp Weight")]
        //public int MaxRampWeight { get; set; }
        //[Display(Name = "Max Takeoff Weight")]
        //public int MaxTakeOffWeight { get; set; }
        //[Display(Name = "Max Zero Fuel Weight")]
        //public int MaxZeroFuelWeight { get; set; }
        //[Display(Name = "Forward Limit")]
        //public float ZeroFuelWeightForwardCG { get; set; }
        //[Display(Name = "Aft Limit")]
        //public float ZeroFuelWeightAftCG { get; set; }
        //[Display(Name = "Forward Limit")]
        //public float TakeoffWeightForwardCG { get; set; }
        //[Display(Name = "Aft Limit")]
        //public float TakeoffWeightAftCG { get; set; }
        //[Display(Name = "Forward Limit")]
        //public float LandingWeightForwardCG { get; set; }
        //[Display(Name = "Aft Limit")]
        //public float LandingWeightAftCG { get; set; }

        ////Payload Properties
        //public int PayloadId { get; set; }
        //public float PayloadWeight { get; set; }
        //public float PayloadArm { get; set; }
        //public float PayloadMoment { get; set; }

        ////Payload Item Properties
        //public int PayloadItemId { get; set; }
        //public string PayloadItemName { get; set; }
        //public float PayloadItemWeight { get; set; }
        //public float PayloadItemMoment { get; set; }
        //public float PayloadItemArm { get; set; }

    }
}
