using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;

namespace WeightAndBalanceApp.Data
{
    public class PayloadEntity
    {
        [Key, ForeignKey("Aircraft")]
        public int PayloadId { get; set; }
        public float PayloadWeight { get; set; }
        public float PayloadArm { get; set; }
        public float PayloadMoment { get; set; }
        public AircraftEntity Aircraft { get; set; }
        [ForeignKey("PayloadItemId")]
        public IEnumerable<PayloadItemsEntity> PayloadItems { get; set; }
        [Display(Name ="Payload Item")]
        public int PayloadItemId { get; set; }
        
        //private PayloadEntity(float arm, float weight, float moment)
        //{
        //    PayloadArm = arm;
        //    PayloadWeight = weight;
        //    PayloadMoment = moment;
        //}

        //public static PayloadEntity CreateFromItems(IEnumerable<PayloadItemsEntity> items)
        //{
        //    var arm = items.Average(i => i.Arm);
        //    var weight = items.Sum(i => i.Weight);
        //    var moment = items.Sum(i => i.Moment);

        //    return new Payload(arm, weight, moment);
        //}

    }
}