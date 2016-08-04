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
        public double BasicEmptyWeight { get; set; }
        public double BasicEmptyWeightArm => (BasicEmptyweightMoment / BasicEmptyWeight);
        public double BasicEmptyweightMoment { get; set; }
        public double ZeroFuelWeight { get; set; }
        public double ZeroFuelWeightArm => (ZeroFuelWeightMoment / ZeroFuelWeight);
        public double ZeroFuelWeightMoment { get; set; }
        public double FuelLoad { get; set; }
        public double FuelLoadMoment { get; set; }
        public double FuelLoadArm { get; set; }
        public double RampWeight { get; set; }
        public double RampWeightArm => (RampWeightMoment / RampWeight);
        public double RampWeightMoment { get; set; }
        public double LessFuelForTaxiWeight { get; set; }
        public double LessFuelForTaxiArm => (LessFuelForTaxiMoment / LessFuelForTaxiWeight);
        public double LessFuelForTaxiMoment { get; set; }
        public double TakeOffWeight { get; set; }
        public double TakeOffWeightArm => (TakeOffWeightMoment / TakeOffWeight);
        public double TakeOffWeightMoment { get; set; }
        public double LessFuelToDestination { get; set; }
        public double LandingWeight { get; set; }
        public double LandingWeightArm => (LandingWeightMoment / LandingWeight);
        public double LandingWeightMoment { get; set; }

        //Max and min values
        public double MaxZeroFuelWeight { get; set; }
        public double MaxRampWeight { get; set; }
        public double MaxTakeOffWeight { get; set; }
        public double MaxLandingWeight { get; set; }
        public double ZeroFuelWeightForwardCG { get; set; }
        public double ZeroFuelWeightAftCG { get; set; }
        public double TakeoffWeightForwardCG { get; set; }
        public double TakeoffWeightAftCG { get; set; }
        public double LandingWeightForwardCG { get; set; }
        public double LandingWeightAftCG { get; set; }

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
