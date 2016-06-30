using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using WeightAndBalanceApp.Data;
using static WeightAndBalanceApp.Data.IdentityModel;

namespace WeightAndBalanceApp.Models
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
        public int ZeroFuelWeightMax { get; set; }
        public int ZeroFuelWeight { get; set; }
        public float ZeroFuelWeightMoment { get; set; }
        [Display(Name = "Fuel Load (lbs.)")]
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
        [Display(Name = "Less fuel to destination (lbs.)")]
        public int LessFuelToDestination { get; set; }
        public int LandingWeight { get; set; }
        public float LandingWeightMoment { get; set; }
        public IEnumerable<PayloadItemsEntity> PayloadItems
        { get
                //Gets the Payload Item Information
            {
                using(var ctx = new WeightAndBalanceDbContext())
                {
                    return ctx.PayloadItems.Select(e => new PayloadItemsEntity
                    {
                        Payload = e.Payload,
                        PayloadItemName = e.PayloadItemName,
                        PayloadItemArm = e.PayloadItemArm,
                        PayloadItemId = e.PayloadItemId,
                        PayloadItemMoment = e.PayloadItemMoment,
                        PayloadItemWeight = e.PayloadItemWeight
                    });
                }
            }
            set
            {
            }
        }
        public PayloadEntity Payload { get; set; }
    }

    public class PayloadViewModel
    {
        [Key, ForeignKey("Aircraft")]
        public int PayloadId { get; set; }
        public float PayloadWeight { get; set; }
        public float PayloadArm { get; set; }
        public float PayloadMoment { get; set; }
        [ForeignKey("PayloadItems")]
        public IEnumerable<PayloadItemsEntity> PayloadItems { get; set; }
        public AircraftEntity Aircraft { get; set; }
    }

    public class PayloadItemsViewModel
    {
        [Key]
        public int PayloadItemId { get; set; }
        public float PayloadItemWeight { get; set; }
        public float PayloadItemMoment { get; set; }
        public float PayloadItemArm { get; set; }
        [ForeignKey("Payload")]
        public PayloadEntity Payload { get; set; }
        [ForeignKey("Aircraft")]
        public AircraftEntity Aircraft { get; set; }
        public string PayloadItemName { get; internal set; }
    }
}