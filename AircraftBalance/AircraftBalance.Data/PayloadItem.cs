using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AircraftBalance.Data
{
    public class PayloadItem
    {
        [Key]
        public int PayloadItemId { get; set; }
        public string PayloadItemName { get; set; }
        public float PayloadItemWeight { get; set; }
        public float PayloadItemMoment { get; set; }
        public float PayloadItemArm { get; set; }

        [ForeignKey("PayloadId")]
        public Payload Payload { get; set; }
        [Display(Name = "Payload")]
        public int PayloadId { get; set; }

        [ForeignKey("AircraftId")]
        public Aircraft Aircraft { get; set; }
        [Display(Name = "Aircraft")]
        public int AircraftId { get; set; }
    }
}
