using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WeightAndBalance.Data
{
    public class PayloadItems
    {
        [Key]
        public int PayloadItemId { get; set; }
        public float PayloadItemWeight { get; set; }
        public float PayloadItemMoment { get; set; }
        public float PayloadItemArm { get; set; }
    }
}