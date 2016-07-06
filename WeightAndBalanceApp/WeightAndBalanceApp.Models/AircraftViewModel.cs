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
        public float BasicEmptyWeightArm { get; set; }
        public float BasicEmptyweightMoment { get; set; }
        public int MaxZeroFuelWeight { get; set; }
        public int ZeroFuelWeight { get; set; }
        public float ZeroFuelWeightArm { get; set; }
        public float ZeroFuelWeightMoment { get; set; }
        [Display(Name = "Fuel Load (lbs.)")]
        public int FuelLoad { get; set; }
        public float FuelLoadMoment { get; set; }
        public float FuelLoadArm { get; set; }
        public int MaxRampWeight { get; set; }
        public int RampWeight { get; set; }
        public float RampWeightArm { get; set; }
        public float RampWeightMoment { get; set; }
        public int LessFuelForTaxiWeight { get; set; }
        public float LessFuelForTaxiArm { get; set; }
        public float LessFuelForTaxiMoment { get; set; }
        public int MaxTakeOffWeight { get; set; }
        public int TakeOffWeight { get; set; }
        public float TakeOffWeightArm { get; set; }
        public float TakeOffWeightMoment { get; set; }
        [Display(Name = "Less fuel to destination (lbs.)")]
        public int LessFuelToDestination { get; set; }
        public int LandingWeight { get; set; }
        public float LandingWeightArm { get; set; }
        public float LandingWeightMoment { get; set; }
        public IEnumerable<PayloadItemsEntity> PayloadItems
        {   get
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
        public PayloadEntity Payload
        { get
            {
                using (var ctx = new WeightAndBalanceDbContext())
                {
                    var payload = ctx.Payload.SingleOrDefault(a => a.PayloadId == AircraftId);
                        return new PayloadEntity
                        {
                            Aircraft = payload.Aircraft,
                            PayloadItemId = payload.PayloadItemId,
                            PayloadItems = payload.PayloadItems,
                            PayloadId = payload.PayloadId,
                            PayloadArm = payload.PayloadArm,
                            PayloadMoment = payload.PayloadMoment,
                            PayloadWeight = payload.PayloadWeight
                        };
                }
            }
            set
            {
            }
        }
    }

    public class PayloadViewModel
    {
        public int PayloadId { get; set; }
        public float PayloadWeight { get; set; }
        public float PayloadArm { get; set; }
        public float PayloadMoment { get; set; }
    }

    public class PayloadItemsViewModel
    {
        public int PayloadItemId { get; set; }
        public float PayloadItemWeight { get; set; }
        public float PayloadItemMoment { get; set; }
        public float PayloadItemArm { get; set; }
        public string PayloadItemName { get; internal set; }
    }
}