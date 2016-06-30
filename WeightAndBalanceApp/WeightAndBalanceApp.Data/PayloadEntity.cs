using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WeightAndBalanceApp.Data
{
    public class PayloadEntity
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
}