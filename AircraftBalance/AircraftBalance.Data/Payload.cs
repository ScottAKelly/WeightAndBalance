﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AircraftBalance.Data
{
    public class Payload
    {
        [Key, ForeignKey("Aircraft")]
        public int PayloadId { get; set; }
        public float PayloadWeight { get; set; }
        public float PayloadArm { get; set; }
        public float PayloadMoment { get; set; }
        public Aircraft Aircraft { get; set; }
        [ForeignKey("PayloadItemId")]
        public IEnumerable<PayloadItem> PayloadItems { get; set; }
        [Display(Name = "Payload Item")]
        public int PayloadItemId { get; set; }

        public static Payload CreateFromItems(IEnumerable<PayloadItem> items)
        {
            var weight = items.Sum(i => i.PayloadItemWeight);
            var moment = items.Sum(i => i.PayloadItemMoment);
            var arm = (moment / weight);

            return new Payload(arm, weight, moment);
        }

        public Payload(float arm, float weight, float moment)
        {
            PayloadArm = arm;
            PayloadWeight = weight;
            PayloadMoment = moment;
        }
    }
}
