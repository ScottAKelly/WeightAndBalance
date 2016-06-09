using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using WeightAndBalance.Data;

namespace WeightAndBalance.Models
{
    public class AircraftViewModel
    {
        [Key]
        public int AircraftId { get; set; }
        public string AircraftName { get; set; }
        public string AircraftMake { get; set; }
        public string AircraftModel { get; set; }
        public int BasicEmptyWeight { get; set; }
        public float BasicEmptyweightMoment { get; set; }
        public int ZeroFuelWeight { get; set; }
        public float ZeroFuelWeightMoment { get; set; }
        public int FuelLoad { get; set; }
        public float FuelLoadMoment { get; set; }
        public float FuelLoadArm { get; set; }
        public int MaxRampWeight { get; set; }
        public int RampWeight { get; set; }
        public float RampWeightMoment { get; set; }
        public int LessFuelForTaxiWeight { get; set; }
        public float LessFuelForTaxiMoment { get; set; }
        public int MaxTakeOffWeight { get; set; }
        public int TakeOffWeight { get; set; }
        public float TakeOffWeightMoment { get; set; }
        public int LessFuelToDestination { get; set; }
        public int LandingWeight { get; set; }
        public float LandingWeightMoment { get; set; }
        public IEnumerable<PayloadItems> PayloadItems { get; set; }
        public Payload Payload { get; set; }
    }
}