using AircraftBalance.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AircraftBalance.Models
{
    public class AircraftViewModel
    {
        //Basic Properties
        public int AircraftId { get; set; }
        public string AircraftName { get; set; }
        public string AircraftMake { get; set; }
        public string AircraftModel { get; set; }
        public int BasicEmptyWeight { get; set; }
        public float BasicEmptyWeightArm { get; set; }
        public float BasicEmptyweightMoment { get; set; }
        public int ZeroFuelWeight { get; set; }
        public float ZeroFuelWeightArm { get; set; }
        public float ZeroFuelWeightMoment { get; set; }
        public int FuelLoadWeight { get; set; }
        public float FuelLoadMoment { get; set; }
        public float FuelLoadArm { get; set; }
        public int RampWeight { get; set; }
        public float RampWeightArm { get; set; }
        public float RampWeightMoment { get; set; }
        public int LessFuelForTaxiWeight { get; set; }
        public float LessFuelForTaxiArm { get; set; }
        public float LessFuelForTaxiMoment { get; set; }
        public int TakeOffWeight { get; set; }
        public float TakeOffWeightArm { get; set; }
        public float TakeOffWeightMoment { get; set; }
        public int LessFuelToDestination { get; set; }
        public int LandingWeight { get; set; }
        public float LandingWeightArm { get; set; }
        public float LandingWeightMoment { get; set; }

        //Max value properties
        public int MaxTakeOffWeight { get; set; }
        public int MaxZeroFuelWeight { get; set; }
        public float ZeroFuelWeightForwardCG { get; set; }
        public float ZeroFuelWeightAftCG { get; set; }
        public float TakeoffWeightForwardCG { get; set; }
        public float TakeoffWeightAftCG { get; set; }
        public float LandingWeightForwardCG { get; set; }
        public float LandingWeightAftCG { get; set; }

        //Payload Properties
        public int PayloadId { get; set; }
        public float PayloadWeight { get; set; }
        public float PayloadArm { get; set; }
        public float PayloadMoment { get; set; }

        //Payload Item Properties
        public int PayloadItemId { get; set; }
        public string PayloadItemName { get; set; }
        public float PayloadItemWeight { get; set; }
        public float PayloadItemMoment { get; set; }
        public float PayloadItemArm { get; set; }

    }
}
