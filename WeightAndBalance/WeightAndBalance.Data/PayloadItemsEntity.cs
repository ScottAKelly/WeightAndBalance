using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace WeightAndBalance.Data
{
    public class PayloadItemsEntity
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
    }
}