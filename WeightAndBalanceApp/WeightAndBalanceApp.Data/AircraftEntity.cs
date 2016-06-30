using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WeightAndBalanceApp.Data
{
    public class AircraftEntity
    {
        [Key]
        public int AircraftId { get; set; }
        [Required]
        public string AircraftName { get; set; }
        [Required]
        public string AircraftMake { get; set; }
        [Required]
        public string AircraftModel { get; set; }
        public int BasicEmptyWeight { get; set; }
        public float BasicEmptyweightMoment { get; set; }
        public int ZeroFuelWeightMax { get; set; }
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
        public IEnumerable<PayloadItemsEntity> PayloadItems { get; set; }
        public PayloadEntity Payload { get; set; }
    }
}