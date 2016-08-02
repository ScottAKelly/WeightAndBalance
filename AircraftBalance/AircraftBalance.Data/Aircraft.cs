using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AircraftBalance.Data
{
    public class Aircraft
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
        public float BasicEmptyWeightArm => (BasicEmptyweightMoment / BasicEmptyWeight);
        public float BasicEmptyweightMoment { get; set; }
        public int ZeroFuelWeight { get; set; }
        public float ZeroFuelWeightArm => (ZeroFuelWeightMoment / ZeroFuelWeight);
        public float ZeroFuelWeightMoment { get; set; }
        public int FuelLoad { get; set; }
        public float FuelLoadMoment => (FuelLoad * FuelLoadArm);
        public float FuelLoadArm { get; set; }
        public int RampWeight { get; set; }
        public float RampWeightArm => (RampWeightMoment / RampWeight);
        public float RampWeightMoment { get; set; }
        public int LessFuelForTaxiWeight { get; set; }
        public float LessFuelForTaxiArm => (LessFuelForTaxiMoment / LessFuelForTaxiWeight);
        public float LessFuelForTaxiMoment { get; set; }
        public int TakeOffWeight { get; set; }
        public float TakeOffWeightArm => (TakeOffWeightMoment / TakeOffWeight);
        public float TakeOffWeightMoment { get; set; }
        public int LessFuelToDestination { get; set; }
        public int LandingWeight { get; set; }
        public float LandingWeightArm => (LandingWeightMoment / LandingWeight);
        public float LandingWeightMoment { get; set; }

        //Max and min values
        public int MaxZeroFuelWeight { get; set; }
        public int MaxRampWeight { get; set; }
        public int MaxTakeOffWeight { get; set; }
        public int MaxLandingWeight { get; set; }
        public float ZeroFuelWeightForwardCG { get; set; }
        public float ZeroFuelWeightAftCG { get; set; }
        public float TakeoffWeightForwardCG { get; set; }
        public float TakeoffWeightAftCG { get; set; }
        public float LandingWeightForwardCG { get; set; }
        public float LandingWeightAftCG { get; set; }

        //Foreign Key info for payload items
        [ForeignKey("PayloadItemId")]
        public IEnumerable<PayloadItem> PayloadItems { get; set; }
        [Display(Name = "Payload Item")]
        public int PayloadItemId { get; set; }

        //Foreign Key info for the payload
        [ForeignKey("PayLoadId")]
        public Payload Payload { get; set; }
        [Display(Name = "Payload")]
        public int PayloadId { get; set; }
    }
}
